using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Patrick Hetland
// Prototype 1
// Prototype 1 Truck
// The code contains variables and loops to run the game

//attach this to the player
public class PlayerEnterTrigger : MonoBehaviour
{
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
        
    
}
