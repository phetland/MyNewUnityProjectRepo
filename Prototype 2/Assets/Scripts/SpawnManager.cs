// Patrick Hetland
// Prototype 2
// Spawns player




using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    //set this array of references in the inspector
    public GameObject[] prefabsToSpawn;


    //variables for spawn position
    private float leftBound = -14;
    private float rightBound = 14;
    private float spawnPosZ = 20;
    private object healthSystem;

    public HealthSystem;
    void Start()
    {
        //get a reference to the health system script
        healthSystem = GameObject.FindGameObjectsWithTag("HealthSystem")
            .GetComponent<healthSystem>();
        //InvokeRepeating("SpawnRandomPrefab", 2, 1.5f);

        StartCoroutine(SpawnRandomPrefabWithCoroutine());



    }

    IEnumerator SpawnRandomPrefabWithCoroutine()
    {
        //add a 3 second delay before first spawning objects
        yield return new WaitForSeconds(3f);

        while (!healthSystem.gameOver)
        while (true)
        {
            SpawnRandomPrefab();

            float randomDelay = Random.Range(1.5f, 3.0f);
            yield return new WaitForSeconds(1.5f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(prefabsToSpawn[0], new Vector3(0, 0, 20), prefabsToSpawn[0].transform.rotation);
            SpawnRandomPrefab();
        
        }
        
    }


    void SpawnRandomPrefab()
    {
        //pick a random animal
        int prefabIndex = Random.Range(0, prefabsToSpawn.Length);

        //generate a random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(leftBound, rightBound), 0, spawnPosZ);

        //spawn our animal
        Instantiate(prefabsToSpawn[prefabIndex], spawnPos, prefabsToSpawn[prefabIndex].transform.rotation);
    }
}

internal class healthSystem
{
}