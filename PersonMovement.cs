using UnityEngine;
using System.Collections;

public class PersonMovement : MonoBehaviour
{
    public Transform pointA; // Starting point
    public Transform pointB; // Destination point
    public float speed = 1.525f; // Speed of movement
    public float waitTime = 5f; // Time to wait at each point after round trip

    private bool movingToB = true; // Whether the object is moving to point B
    private bool waiting = false; // Whether the object is waiting at the destination

    void Update()
    {
        if (!waiting)
        {
            // Move towards the target point
            Transform target = movingToB ? pointB : pointA;
            MoveTowards(target);

            // Check if the object has reached the target
            if (Vector3.Distance(transform.position, target.position) < 0.01f)
            {
                // Start waiting at the destination after reaching it
                StartCoroutine(WaitAtDestination());
            }
        }
    }

    private void MoveTowards(Transform target)
    {
        // Move the object towards the target point
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    private IEnumerator WaitAtDestination()
    {
        waiting = true;
        yield return new WaitForSeconds(waitTime); // Wait for 5 seconds at the destination
        waiting = false;

        // Switch direction after waiting
        movingToB = !movingToB; // Switch the target to move back and forth
    }
}
