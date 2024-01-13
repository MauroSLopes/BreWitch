using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbsSpawner : MonoBehaviour
{
    private int vector3XValue = 14;
    private int vector3ZValue = 10;
    public GameObject[] herbsPrefab;

    void Start()
    {
        InvokeRepeating("CollisionVerifier", 1f, 2f);
    }

    void CollisionVerifier(){
        Vector3 location = RandomLocation();
        Collider[] hitColliders = Physics.OverlapSphere(location, 0.2f);
        if (hitColliders.Length < 1){
            HerbSpawnerFunction(location);
        }
    }

    Vector3 RandomLocation(){
        Vector3 randomSpawnLocation = new Vector3(Random.Range(vector3XValue,-vector3XValue), 0 
        ,Random.Range(vector3ZValue,-vector3ZValue));
        return randomSpawnLocation;
    }
    void HerbSpawnerFunction(Vector3 local){
        int randomHerb = Random.Range(0, herbsPrefab.Length);
        Instantiate(herbsPrefab[randomHerb], local, Quaternion.identity);
    }
}
