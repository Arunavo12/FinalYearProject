using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // The player's transform to follow
    public float smoothTime = 0.3f; // Time taken to smoothly follow the player
    private Vector3 velocity = Vector3.zero; // Current velocity of the smooth camera movement

    void LateUpdate()
    {
        // Calculate the desired target position with an offset for the camera
        Vector3 targetPosition = target.position + new Vector3(0, 0, transform.position.z);

        // Smoothly move the camera towards the target position
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }
}
