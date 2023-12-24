using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class MovForward : MonoBehaviour
{
    public float speed = 5f; // Adjust the movement speed as needed

    void Update()
    {
        // Calculate diagonal movement vector
        Vector2 diagonalMovement = new Vector2(1f, 1f).normalized;

        // Move the object diagonally using Rigidbody2D
        MoveDiagonally(diagonalMovement);
    }

    void MoveDiagonally(Vector2 movement)
    {
        // Get the Rigidbody2D component attached to the GameObject
        Rigidbody2D rb2D = GetComponent<Rigidbody2D>();

        // Check if the Rigidbody2D component exists
        if (rb2D != null)
        {
            // Set the velocity to move the object diagonally
            rb2D.velocity = movement * speed;
        }
        else
        {
            Debug.LogError("Rigidbody2D component not found. Attach a Rigidbody2D component to the GameObject.");
        }
    }

}
