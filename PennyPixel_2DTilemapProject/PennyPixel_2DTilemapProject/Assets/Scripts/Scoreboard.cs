using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    public static int totalScore = 0;

    private void OnGUI()
    {
        GUI.Box(new Rect(100, 100, 200, 100), "Score = " + totalScore.ToString());
    }
}
