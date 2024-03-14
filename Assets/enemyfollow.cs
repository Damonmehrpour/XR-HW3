using System.Collections;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Find the player object with the "Player" tag
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // Ensure player is found before proceeding
        if (player != null)
        {
            // Calculate the direction to the player
            Vector3 direction = player.transform.position - transform.position;
            direction.y = 0f; // Ensure the enemy doesn't tilt upwards or downwards

            // Rotate towards the player
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 1 * Time.deltaTime);

            // Move towards the player
            transform.position += transform.forward * 1f * Time.deltaTime;
        }
    }
}
