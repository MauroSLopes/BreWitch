using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    
    // Instantiate the enemy array
    public GameObject[] Enemy;

    // Spawns enemy after 3s
    void Start()
    {
        InvokeRepeating("EnemySpawnerLocal", 1f, 1.5f);
    }

    // Instantiate enemy spawn location
    void EnemySpawnerLocal()
    {
        // Random variables
        float directionSelector = Mathf.Round(Random.value);
        int randomEnemy = Random.Range(0, Enemy.Length);
        bool sideSelector = Random.value > 0.5;

        // spawn on top or bottom
        if (directionSelector == 0)
        {

            // Top
            if (sideSelector)
            {
                // Randomize the X enemy spawn location
                Vector3 enemyPos = new Vector3(Random.Range(-15, 15), 0, 12);
                Instantiate(Enemy[randomEnemy], enemyPos, transform.rotation);
            }

            // Botton 
            else
            {
                // Randomize the X enemy spawn location
                Vector3 enemyPos = new Vector3(Random.Range(-15, 15), 0, -12);
                Instantiate(Enemy[randomEnemy], enemyPos, transform.rotation);
            }
        }
        
        // spawns on Left or Right
        if (directionSelector == 1)
        {

            // Right
            if (sideSelector)
            {
                // Randomize the Z enemy spawn location
                Vector3 enemyPos = new Vector3(16, 0, Random.Range(-12, 12));
                Instantiate(Enemy[randomEnemy], enemyPos, transform.rotation);
            }

            // Left
            else
            {
                // Randomize the X enemy spawn location
                Vector3 enemyPos = new Vector3(-16, 0, Random.Range(-12, 12));
                Instantiate(Enemy[randomEnemy], enemyPos, transform.rotation);
            }
        }
    }
}
