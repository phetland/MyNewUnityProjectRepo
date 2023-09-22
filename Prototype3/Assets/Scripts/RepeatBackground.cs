﻿// Patrick Hetland 
// Prototype 3 
// Repeats the background



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        //save the starting position as a Vector3  
        startPosition = transform.position;

        //set the repeatWidth to hald of the width of the background
        repeatWidth = GetComponent<BoxCollider>().size.x / 1;
    }

    // Update is called once per frame
    void Update()
    {
        //if the background is farther to the left than the repeatWidth, reset it to its start position
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
