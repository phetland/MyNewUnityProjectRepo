﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

//Patrick Hetland
//Challenge 1
//Challenge 1 Plane
//The code has variables and loops to control the game


public class Propeller : MonoBehaviour

{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f,0f,speed*Time.fixedDeltaTime,Space.Self);
    }
}
