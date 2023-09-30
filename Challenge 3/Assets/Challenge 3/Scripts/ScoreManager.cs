//Julian Avila
//Challenge 3
//Manages score and losses of the player
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    
    public static bool won = false;
    public static int score = 0;
    private PlayerControllerX playerControllerScript;
    public Text textbox;

    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();
        won = false;
        score = 0;
    }
    // Update is called once per frame
    void Update()
    {
        //if game is not over display score
        if (!playerControllerScript.gameOver)
        {
            textbox.text = "Score: " + score;
        }

        //win condition: score 3 points
        if (score >= 10)
        {
            won = true;
            playerControllerScript.gameOver = true;
        }

        if (playerControllerScript.gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to try again!";
            }
            else
            {
                textbox.text = "You lose!\n Press R to try again!";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                Start();
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);

            }
        }
    }
}
