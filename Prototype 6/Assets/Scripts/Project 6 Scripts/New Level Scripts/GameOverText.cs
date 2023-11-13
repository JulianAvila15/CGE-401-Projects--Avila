using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverText : MonoBehaviour
{
    [SerializeField] private RightCube player2;
    [SerializeField] private LeftCube player1;
    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (NewGameManager.gameOver)
        {
           
            if (NewGameManager.firstPlayerScore > NewGameManager.secondPlayerScore || (player1.health > 0 && player2.health==0))
            {
                GetComponent<Text>().text = "Player 1 Wins!" + "\nPress R to restart";
                GetComponent<Text>().color = new Color(0, 20, 255);
            }
            else if (NewGameManager.secondPlayerScore > NewGameManager.firstPlayerScore || (player2.health > 0 && player1.health==0))
            {
                GetComponent<Text>().text = "Player 2 Wins!" + "\nPress R to restart";
                GetComponent<Text>().color = new Color(232, 255, 0);
            }
            else
            {
                GetComponent<Text>().text = "Tie!" + "\nPress R to restart";
            }



        }
    }
}
