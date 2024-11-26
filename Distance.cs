using UnityEngine;

public class Distance : MonoBehaviour
{
    public Transform pointA;  // Assign Point A in the Inspector
    public Transform pointB;  // Assign Point B in the Inspector

    void Start()
    {
        if (pointA != null && pointB != null)
        {
            float distance = Vector3.Distance(pointA.position, pointB.position);
            Debug.Log("The distance between Point A and Point B is: " + distance);
        }
        else
        {
            Debug.LogError("Please assign Point A and Point B in the Inspector!");
        }
    }
}
