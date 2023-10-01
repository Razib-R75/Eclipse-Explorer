using UnityEngine;

public class ResetOnCollision : MonoBehaviour
{
    private Vector3 startPosition;

    private void Start()
    {
        // Store the initial position of the object
        startPosition = transform.position;
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves the object you want to reset
        if (collision.gameObject.CompareTag("YourCollisionTag"))
        {
            // Reset the object's position to the start position
            transform.position = startPosition;
        }
    }
}
