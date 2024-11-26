using System.Collections;
using UnityEngine;

public class LightGlowFor10Seconds : MonoBehaviour
{
    public Light myLight;  // Drag your light object into this in the Inspector

    void Start()
    {
        // Start the glow process
        StartCoroutine(GlowFor10Seconds());
    }

    IEnumerator GlowFor10Seconds()
    {
        // Turn the light on
        myLight.enabled = true;

        // Wait for 10 seconds
        yield return new WaitForSeconds(10);

        // Turn the light off
        myLight.enabled = false;
    }
}
