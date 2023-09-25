/*Julian Avila
 * Prototype 3
 * Manages UI and win/loss conditions
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    public PlayerController playerControllerScript;

    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;

        if(scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript ==null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        //Display score until game is over
        if(!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        //Loss Condition: Hit the obstacle (end game)
        if(playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to try again!";
        }

        if(score>= 10 && playerControllerScript.isOnGround)
        {
            playerControllerScript.gameOver = true;
            won = true;

            playerControllerScript.StopRunning();

            scoreText.text = "You Win!" + "\n" + "Press R to try again!";
        }

        if(playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }


    }
}
