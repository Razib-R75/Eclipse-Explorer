using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EclipseAnimation : MonoBehaviour
{
    public Transform moon; // Reference to the moon's transform.
    public float eclipseDuration = 10.0f; // Duration of the eclipse in seconds.

    private float eclipseTimer = 0.0f;
    private Vector3 moonStartPosition;
    private Vector3 sunStartPosition;

    void Start()
    {
        // Store the moon's initial position.
        moonStartPosition = moon.position;
        // Store the sun's initial position.
        sunStartPosition = Vector3.zero; // Assume the sun is at the world origin.
    }

    void Update()
    {
        // Increment the eclipse timer.
        eclipseTimer += Time.deltaTime;

        // Calculate the interpolation factor (0 to 1) based on the eclipse timer.
        float t = Mathf.Clamp01(eclipseTimer / eclipseDuration);

        // Interpolate the moon's position between its starting position and the sun's position.
        Vector3 eclipsePosition = Vector3.Lerp(moonStartPosition, sunStartPosition, t);
        moon.position = eclipsePosition;

        // Check if the eclipse is complete.
        if (eclipseTimer >= eclipseDuration)
        {
            // Reset the timer and moon's position.
            eclipseTimer = 0.0f;
            moon.position = moonStartPosition;
        }
    }
}
