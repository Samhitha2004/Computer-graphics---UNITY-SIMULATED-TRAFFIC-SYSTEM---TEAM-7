using System.Collections;
using UnityEngine;

public class LightGlowAndWait : MonoBehaviour
{
    public Light myLight;  // Drag your light object into this in the Inspector

    void Start()
    {
        // Start the cycle of waiting and glowing
        StartCoroutine(GlowAndWait());
    }

    IEnumerator GlowAndWait()
    {
        while (true)
        {
            // Wait for 10 seconds with the light off
            myLight.enabled = false;
            yield return new WaitForSeconds(10);

            // Turn the light on for the next 10 seconds
            myLight.enabled = true;
            yield return new WaitForSeconds(10);
        }
    }
}
