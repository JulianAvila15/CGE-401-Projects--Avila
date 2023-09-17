/*
 * Julian Avila
 * Challenge 2
 * Manages when the game is over
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverManager : MonoBehaviour
{
    private HealthSystem healthSystemScript;
    private DisplayScore scoreScript;
    public bool gameOver = false;
    public GameObject gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        healthSystemScript = GameObject.FindGameObjectWithTag("HealthSystem").GetComponent<HealthSystem>();
        scoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();

    }

    // Update is called once per frame
    void Update()
    {
        if (healthSystemScript.health <= 0||scoreScript.score>=5)
        {
            
            gameOver = true;
            gameOverText.SetActive(true);


            if(scoreScript.score >= 5)
            gameOverText.GetComponent<Text>().text = "You win! \n Press R to Restart";
            else if (healthSystemScript.health <= 0)
                gameOverText.GetComponent<Text>().text = "You lose! \n Press R to Restart";

            //Press R to restart if game is over
            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
            }
        }
    }
}
