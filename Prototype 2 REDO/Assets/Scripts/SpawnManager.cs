using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] prefabsToSpawn;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {

            //pick a random animal index
            int prefabIndex = Random.Range(0, prefabsToSpawn.Length);
            //Step 1:
            //Spawn oth prefab at top of screen
            Instantiate(prefabsToSpawn[prefabIndex], new Vector3(0, 0, 20), prefabsToSpawn[prefabIndex].transform.rotation);
        }
    }
}

