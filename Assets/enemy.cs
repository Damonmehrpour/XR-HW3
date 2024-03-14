using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour

{
    // Define a method to handle collision events
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision involves a specific tag or layer
        if (collision.gameObject.CompareTag("Monster"))
        {
            // Destroy the collided object
            Debug.Log("Player object not found!");

            Destroy(collision.gameObject);

        }
    }
}