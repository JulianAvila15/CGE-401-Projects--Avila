using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreManager : MonoBehaviour
{
    public static bool gameOver = false;
    public static bool won = false;
    public static int score = 0;

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
        //if game is not over display score
        if (!gameOver)
        {
            textbox.text = "Score: " + score;
        }

        //win condition: score 3 points
        if(score>=3)
        {
            won = true;
            gameOver = true;
        }

        if(gameOver)
        {
            if (won)
            {
                textbox.text = "You win!\nPress R to try again!";
            }
            else
            {
                textbox.text = "You lose!\n Press R to try again!";
            }
            if(Input.GetKeyDown(KeyCode.R))
            {
                Start();
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }
    }
}
