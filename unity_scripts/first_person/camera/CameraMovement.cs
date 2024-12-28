using UnityEngine;

public class CameraMovement : MonoBehaviour
{   

    // Transform is used for determines the position, rotation
    // and Scale. Here we receive the cameraPosition defined in
    // player obj and make the camera position receive these
    // positions
    public Transform cameraPosition;

    void Start()
    {
        
    }
    void Update()
    {
        transform.position = cameraPosition.position;
    }
}
