using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CAMERALOOK : MonoBehaviour
{
    public float sensitivity = 15f;

    void Update()
    {
        // Keyboard input for camera rotation
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 rotation = new Vector3(-verticalInput, horizontalInput, 0) * sensitivity * Time.deltaTime;

        // Rotate the camera
        transform.eulerAngles += rotation;
    }
}
