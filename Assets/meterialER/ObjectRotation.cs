using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public float rotationSpeed = 2.0f;

    private Vector3 lastMousePosition;

    void Update()
    {
        // Check for mouse input
        if (Input.GetMouseButtonDown(0))
        {
            // Capture the current mouse position
            lastMousePosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            // Calculate the mouse movement since the last frame
            Vector3 deltaMousePosition = Input.mousePosition - lastMousePosition;

            // Rotate the object based on mouse movement
            float rotationX = deltaMousePosition.y * rotationSpeed;
            float rotationY = -deltaMousePosition.x * rotationSpeed;

            // Apply rotation to the object
            transform.Rotate(Vector3.up, rotationY, Space.World);
            transform.Rotate(Vector3.right, rotationX, Space.World);

            // Update the last mouse position for the next frame
            lastMousePosition = Input.mousePosition;
        }
    }
}
