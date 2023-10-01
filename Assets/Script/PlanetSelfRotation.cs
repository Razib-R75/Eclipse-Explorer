using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetSelfRotation : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 10.0f; // Adjust the speed of rotation in the Inspector.

    void Update()
    {
        // Rotate the planet around its own up axis (usually the Y-axis).
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}