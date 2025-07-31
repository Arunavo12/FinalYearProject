using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage; // The amount of damage inflicted upon the player upon collision
    public PlayerHealth playerHealth; // Reference to the player's health component

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerHealth.TakeDamage(damage); // Reduces the player health upon collision
        }
    }
}
