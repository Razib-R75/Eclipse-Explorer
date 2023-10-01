using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public float dayDuration = 10.0f; // Duration of a full day in seconds

    private Light sunLight;
    private float timeOfDay = 0.0f;

    private void Start()
    {
        // Find the directional light in the scene
        sunLight = GetComponent<Light>();
        if (sunLight == null)
        {
            Debug.LogError("DayNightCycle script requires a directional light in the scene.");
            enabled = false;
            return;
        }
    }

    private void Update()
    {
        // Calculate the angle to rotate the sun based on the time of day
        float angle = (timeOfDay / dayDuration) * 360.0f;

        // Rotate the light around the Y-axis to simulate the day-night cycle
        sunLight.transform.rotation = Quaternion.Euler(angle, 0, 0);

        // Update the time of day
        timeOfDay += Time.deltaTime;

        // Wrap around the timeOfDay value to start a new day
        if (timeOfDay >= dayDuration)
        {
            timeOfDay = 0.0f;
        }
    }
}

