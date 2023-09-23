using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    void Update()
    {
        if (Input.GetMouseButton(0)) // Check if the left mouse button is clicked
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit)) // Cast a ray from the mouse position
            {
                Vector3 targetPosition = new Vector3(hit.point.x, transform.position.y, hit.point.z); // Get the point on the same Y-axis as the player
                Vector3 lookDirection = targetPosition - transform.position; // Calculate the direction to look at

                if (lookDirection != Vector3.zero)
                {
                    Quaternion toRotation = Quaternion.LookRotation(lookDirection);
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, 360f * Time.deltaTime);
                }
            }
        }
    }
}
