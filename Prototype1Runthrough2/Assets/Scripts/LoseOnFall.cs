﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Patrick Hetland
// Prototype 1
// Prototype 1 Truck
// The code contains variables and loops to run the game

//attach this script to the player
public class LoseOnFall : MonoBehaviour
{

   
    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            ScoreManager.gameOver = true; 
        }
        
    }
}
