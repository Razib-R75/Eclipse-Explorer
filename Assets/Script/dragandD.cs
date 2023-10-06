using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragandD : MonoBehaviour
{
    private bool isDragging = false;
    private Vector3 offset;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Check if the mouse is over the object
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.transform == transform)
            {
                // Start dragging
                isDragging = true;
                offset = transform.position - hit.point;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // Stop dragging
            isDragging = false;
        }

        if (isDragging)
        {
            // Calculate the new position based on mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // Freeze the Y coordinate and only update X and Z
                Vector3 newPosition = new Vector3(hit.point.x + offset.x, transform.position.y, hit.point.z + offset.z);
                transform.position = newPosition;
            }
        }
    }
}
