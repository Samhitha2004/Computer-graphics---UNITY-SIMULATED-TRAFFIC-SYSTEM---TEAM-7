using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public Light lightSource;  // Drag and drop the Light component in the Inspector
    private float timer = 0f;
    private float interval = 5f;  // Time interval in seconds

    void Start()
    {
        if (lightSource == null)
        {
            lightSource = GetComponent<Light>();  // Automatically get the Light component
        }
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= interval)
        {
            lightSource.enabled = !lightSource.enabled;  // Toggle the light
            timer = 0f;  // Reset the timer
        }
    }
}
