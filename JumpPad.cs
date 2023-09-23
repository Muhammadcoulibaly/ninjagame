using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // Adjust the jump force as needed

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            CharacterController characterController = other.GetComponent<CharacterController>();
            if (characterController != null)
            {
                Vector3 jumpDirection = transform.up; // Use the jump pad's up direction as the jump direction
                characterController.Move(jumpDirection * jumpForce * Time.deltaTime);
            }
        }
    }
}
