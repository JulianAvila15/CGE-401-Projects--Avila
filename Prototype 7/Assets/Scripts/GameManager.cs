/*
 * Julian Avila
 * Prototype 7
 * Manages the game and win/loss conditions
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static bool gameOver;
    public Text winText,lossText,waveText;
    [SerializeField] private SpawnManager spawner;
    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        winText.gameObject.SetActive(false);
        lossText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        waveText.text = "Wave: " + spawner.waveNumber;

        if(gameOver==true)
        {
            if(spawner.waveNumber >= 10)
            winText.gameObject.SetActive(true);
            else
            {
                lossText.gameObject.SetActive(true);
            }

            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }

        }
    }
}
