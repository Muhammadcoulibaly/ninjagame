using UnityEngine;

public class CameraRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 5f;

    void Update()
    {
        if (Input.GetMouseButton(0)) // Check if the left mouse button is clicked
        {
            float mouseX = Input.GetAxis("Mouse X"); // Get the horizontal mouse movement
            float mouseY = Input.GetAxis("Mouse Y"); // Get the vertical mouse movement

            Vector3 rotation = new Vector3(-mouseY, mouseX, 0f) * rotationSpeed; // Create the rotation vector based on mouse movement
            transform.eulerAngles += rotation; // Apply rotation to the camera
        }
    }
}
