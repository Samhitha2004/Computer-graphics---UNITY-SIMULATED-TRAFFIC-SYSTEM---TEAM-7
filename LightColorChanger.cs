using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColorChanger : MonoBehaviour
{
    public Light lightSource;  // Reference to the Light component
    public Color[] colors;     // Array of colors to cycle through
    private int currentColorIndex = 0;

    void Start()
    {
        if (lightSource == null)
        {
            lightSource = GetComponent<Light>();  // Get the Light component if not assigned
        }

        StartCoroutine(ChangeColor());
    }

    IEnumerator ChangeColor()
    {
        while (true)
        {
            // Change the light's color
            lightSource.color = colors[currentColorIndex];

            // Move to the next color, loop back to the first if needed
            currentColorIndex = (currentColorIndex + 1) % colors.Length;

            // Wait for 5 seconds before changing the color again
            yield return new WaitForSeconds(5f);
        }
    }
}