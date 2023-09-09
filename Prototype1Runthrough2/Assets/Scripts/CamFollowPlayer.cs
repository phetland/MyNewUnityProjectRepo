using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Patrick Hetland
// Prototype 1
// Prototype 1 Truck
// The code contains variables and loops to run the game

public class CamFollowPlayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);


    //Update is called once per frame
    void Update()
    { 
        transform.position = player.transform.position + offset;
    }
}