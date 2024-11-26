using UnityEngine;

public class CarLight : MonoBehaviour
{
    public Light lightSource;  // Drag and drop the Light component in the Inspector
    private float timer = 0f;
    private float interval = 5f;  // Time interval in seconds
    private bool isLightOn = false;  // Track light state

    void Start()
    {
        if (lightSource == null)
        {
            lightSource = GetComponent<Light>();  // Automatically get the Light component
        }
        lightSource.enabled = isLightOn;  // Ensure the light starts in the "off" state
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            isLightOn = !isLightOn;  // Toggle light state
            lightSource.enabled = isLightOn;  // Apply the light state
            timer = 0f;  // Reset the timer
        }
    }
}
