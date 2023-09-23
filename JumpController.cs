using UnityEngine;

public class JumpController : MonoBehaviour
{
    [SerializeField] private float jumpForce = 10f;
    [SerializeField] private float doubleJumpForce = 8f;
    [SerializeField] private int maxJumps = 2;

    private int jumpsRemaining;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpsRemaining = maxJumps;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && jumpsRemaining > 0)
        {
            Jump();
            jumpsRemaining--;

           
        }
    }

    private void Jump()
    {
        if (jumpsRemaining == maxJumps)
        {
            // Initial jump
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }
        else
        {
            // Double jump
            rb.velocity = new Vector3(rb.velocity.x, doubleJumpForce, rb.velocity.z);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            // Reset jumps when player touches the ground
            jumpsRemaining = maxJumps;
        }
    }
}
