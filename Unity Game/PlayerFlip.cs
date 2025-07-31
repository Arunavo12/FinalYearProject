using UnityEngine;

public class PlayerFlip : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Get the horizontal input (assuming you're using the Horizontal axis for movement).
        float horizontalInput = Input.GetAxis("Horizontal");

        // Flip the player's sprite based on the input direction.
        if (horizontalInput > 0)
        {
            spriteRenderer.flipX = false; // Face right
        }
        else if (horizontalInput < 0)
        {
            spriteRenderer.flipX = true; // Face left
        }
    }
}
