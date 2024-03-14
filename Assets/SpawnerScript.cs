using System.Collections;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject monster;

    void Start()
    {
        // Start the SpawnCube coroutine
        StartCoroutine(SpawnCube());
    }

    IEnumerator SpawnCube()
    {
        while (true)    
        {
            // Spawn a cube prefab at the spawner's position
            Instantiate(monster, transform.position, Quaternion.identity);

            // Wait for 5 seconds before spawning the next cube
            yield return new WaitForSeconds(7f);
        }
    }
}