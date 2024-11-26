using UnityEngine;

public class TrafficLightChange : MonoBehaviour
{
    // Array of colors
    private Color[] colors = { Color.red, Color.green, Color.yellow };
    private int currentColorIndex = 0;
    private float changeInterval = 5f; // 5 seconds

    private void Start()
    {
        // Start the color change process
        InvokeRepeating("ChangeColor", 0f, changeInterval);
    }

    private void ChangeColor()
    {
        // Get the Renderer component
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            // Change the material color to the current color
            renderer.material.color = colors[currentColorIndex];

            // Move to the next color
            currentColorIndex = (currentColorIndex + 1) % colors.Length;
        }
    }
}