using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{
    // Enemy Variables
    private float speed = 2.5f;
    private GameObject[] playerDetector;

    // Start is called before the first frame update
    void Start()
    {
        // Detecting player and Localizer
        playerDetector = GameObject.FindGameObjectsWithTag("Player");
        InvokeRepeating("MoveEnemy", 0.2f, 0.2f);
    }

    // Moves the Enemy
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
 
    // Turn the enemy to the player
    void MoveEnemy()
    {
        transform.LookAt(playerDetector[0].transform.position);
    }

    // Destroy the Enemy
    // Change to player after
    private void OnTriggerEnter(Collider other)
    {   
        Destroy(gameObject);
    }
}
