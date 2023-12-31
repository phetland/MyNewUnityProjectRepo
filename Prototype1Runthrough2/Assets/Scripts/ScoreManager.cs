﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

// Patrick Hetland
// Prototype 1
// Prototype 1 Truck
// The code contains variables and loops to run the game
public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;
    public static bool outOfBounds;

    public Text textbox;

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //If the game is not over, display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }


        //win condition: 3 or more points
        if (score >= 5)
        {
            won = true;
            gameOver = true;
            outOfBounds = false;
        }

        if (gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to Try Again!";
            }
            else 
            {
                textbox.text = "Out of bounds! You lose!\nPress R to Try Again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

            if (gameOver)
            {
                if (outOfBounds)
                {
                    textbox.text = "Out of bounds! You lose!\nPress R to Try Again!";
                }
            }

        }



    }
}      

        

