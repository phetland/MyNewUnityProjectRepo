using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        void onGUI()
        {

            GUI.Box(new Rect(100, 100, 100, 100), "Score");
        }
    }
}
