using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

// Patrick Hetland
// Prototype 1
// Prototype 1 Truck
// The code contains variables and loops to run the game

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;

    public float horizontalInput;
    public float forwardInput;

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        //Move Forward with forward input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
