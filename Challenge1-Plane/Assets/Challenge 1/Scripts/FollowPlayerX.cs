using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Patrick Hetland
//Challenge 1
//Challenge 1 Plane
//The code has variables and loops to control the game

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
