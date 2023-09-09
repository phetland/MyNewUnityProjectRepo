using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Patrick Hetland
// Prototype 1
// Prototype 1 Truck
// The code contains variables and loops to run the game

//Attach this to a trigger zone
public class TriggerZoneAddScoreOnce : MonoBehaviour
{
    private bool triggered = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            ScoreManager.score++;
        }

    }



}
