//Patrick Hetland 
//UIManager
//Displays score and keeps track of it


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;

  

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerX == null)
        {
            playerControllerX = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        //Display score until game is over
        if (!playerControllerX.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        //Loss Condition: Hit the obstacle
        if (playerControllerX.gameOver && !won)
        {
            scoreText.text = "You Lose!\nPress R to Try Again!";
        }

        //Win Condition: 20 points 
        if (score >= 10)
        {
            playerControllerX.gameOver = true;
            won = true;

            //Stop player running

            scoreText.text = "You Win!\nPress R to Try Again!";
        }

        if (playerControllerX.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

    }
}
