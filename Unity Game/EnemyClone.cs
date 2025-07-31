using UnityEngine;

public class EnemyClone : MonoBehaviour
{
    public GameObject clonePrefab;     // The clone prefab to be created again when hit by a bullet

    // Called when a collision occurs with another collider.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Checks if the colliding object has the "Bullet" tag.
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Create a clone of the enemy at the same position.
            Instantiate(clonePrefab, transform.position, Quaternion.identity);

            // Destroy the original enemy and the bullet.
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
