// Patrick Hetland
// Prototype 2
// Destroys object when out of bounds




using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;// Start is called before the first frame update

    private HealthSystem healthSystemScript;
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        //if food goes out of bounds 
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
       
        }
        //if animals go out of bounds
        if  (transform.position.z < bottomBound)
        {
            Debug.Log("Game Over!");

            //grab the health system 
            healthSystemScript.TakeDamage();
            Destroy(gameObject);
        }
    }
}

internal class HealthSystem
{
    internal void TakeDamage()
    {
        throw new NotImplementedException();
    }
}