using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerbManager : MonoBehaviour
{
    public int[] herbInventory = new int[2];
    private int arrayPositionCounter = 0;

    private void AddInventory(int herbType){
        if(arrayPositionCounter == 2){
            System.Array.Clear(herbInventory, 0, herbInventory.Length);
            arrayPositionCounter = 0;
        }
        herbInventory[arrayPositionCounter] = herbType;
        arrayPositionCounter++;
    }

    private void OnTriggerEnter(Collider other){
        Herb pickup = other.gameObject.GetComponent<Herb>();
        if (pickup){
            AddInventory(pickup.id);
            Destroy(other.gameObject);
        }
        
    }
}
