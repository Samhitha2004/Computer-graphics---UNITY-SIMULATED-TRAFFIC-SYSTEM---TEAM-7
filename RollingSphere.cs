using UnityEngine;

public class RollingSphere : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 2f;
    public float rayDistance = 3f;
    public LayerMask obstacleLayer;

    private Vector3 currentDirection;

    void Start()
    {
        // Set initial random direction
        currentDirection = Random.insideUnitSphere;
        currentDirection.y = 0; // Keep movement in the horizontal plane
        currentDirection.Normalize();
    }

    void Update()
    {
        // Move the sphere
        transform.position += currentDirection * moveSpeed * Time.deltaTime;

        // Cast a ray in the current direction to detect obstacles
        if (Physics.Raycast(transform.position, currentDirection, out RaycastHit hit, rayDistance, obstacleLayer))
        {
            // Obstacle detected, choose a new random direction
            Debug.DrawLine(transform.position, hit.point, Color.red);
            AvoidObstacle();
        }
        else
        {
            // No obstacle, show debug ray
            Debug.DrawRay(transform.position, currentDirection * rayDistance, Color.green);
        }
    }

    void AvoidObstacle()
    {
        // Generate a new direction away from the obstacle
        Vector3 newDirection = Vector3.Reflect(currentDirection, Vector3.up);
        newDirection = Random.insideUnitSphere;
        newDirection.y = 0; // Keep horizontal movement
        currentDirection = newDirection.normalized;
    }
}
