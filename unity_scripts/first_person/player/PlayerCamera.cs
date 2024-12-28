using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float sensX;
    public float sensY;
    public Transform orientation;

    // xRotation from the assigned camera
    float xRotation;
    
    // yRotation from the assigned camera
    float yRotation;

    void Start()
    {   
        // lock cursor in center of screen
        Cursor.lockState = CursorLockMode.Locked;
        // cursor invisible
        Cursor.visible = false;
    }


    void Update()
    {
        // Get mouse input
        // End position of input is defined by input x sens * moviment seconds
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        // Adjust rotations
        yRotation += mouseX;
        xRotation -= mouseY;

        // Clamp xRotation to limit vertical rotation
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Apply rotations
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0, yRotation, 0);
    }
}
