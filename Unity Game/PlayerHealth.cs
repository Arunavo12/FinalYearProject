using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10; // The max health the player can have
    public int health; // The current health of the player after being hit, etc.
    public Transform respawnPoint; // The spot where the player goes back after health goes to 0

    private Vector3 initialPosition; // Where the player starts the game
    
    void Start()
    {
        health = maxHealth; // Full health at the start (10)
        initialPosition = transform.position; // Sets the same start point every time
    }

    public void TakeDamage(int damage)
    {
        health -= damage; // Taking damage
        if (health <= 0)
        {
            Respawn(); // Takes the player back to respawn after health goes to 0
        }
    }

    public void Respawn()
    {
        health = maxHealth; // After respawn, has maxhealth againn
        transform.position = initialPosition; // Respawns where the player started from
    }
}
