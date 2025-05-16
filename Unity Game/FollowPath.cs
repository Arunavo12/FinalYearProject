using UnityEngine;

public class FollowPath : MonoBehaviour
{
    [SerializeField] Transform[] Points; //  Waypoints to go from one point to the next one
    [SerializeField] private float moveSpeed = 2f; // Walk speed that can be set in-game
    private int pointsIndex = 0; // Index of the current waypoint from which the Enemy walks to the next one

    void Start()
    {
        transform.position = Points[pointsIndex].transform.position; // Sets the position of object as the position of the first waypoint
    }

    void Update()
    {
        if (pointsIndex <= Points.Length - 1)
        {
            // Move object from the current waypoint to the next one using MoveTowards method
            transform.position = Vector2.MoveTowards(transform.position, Points[pointsIndex].transform.position, moveSpeed * Time.deltaTime);

            // Check if the object has reacheed the current waypoint
            if ((Vector2)transform.position == (Vector2)Points[pointsIndex].transform.position)
            {
                pointsIndex += 1; // Move to the next waypoint

                //  Loops the path
                if (pointsIndex >= Points.Length)
                {
                    pointsIndex = 0;
                }
            }
        }
    }
}
