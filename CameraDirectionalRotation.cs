using UnityEngine;

public class CameraDirectionalRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 5f; // Camera rotation speed

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RotateCamera(Vector3.forward);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            RotateCamera(Vector3.back);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            RotateCamera(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            RotateCamera(Vector3.right);
        }
    }

    void RotateCamera(Vector3 direction)
    {
        Quaternion toRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    }
}
