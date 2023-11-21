/*
 * Julian Avila
 * Challenge 7
 * Manages win and loss conditions
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public Text winText, lossText, waveText;
    public static int enemyScore;
    public SpawnManagerX spawner;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        winText.gameObject.SetActive(false);
        lossText.gameObject.SetActive(false);
        enemyScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        waveText.text = "Wave: " + (spawner.waveCount);
        
            if(enemyScore >= spawner.waveCount)
            gameOver = true;

        if (gameOver == true)
        {
            if (spawner.waveCount >= 10)
                winText.gameObject.SetActive(true);
            else 
            {
                lossText.gameObject.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
    }
}
