using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScores : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name == "Player 1 Cube Score")
            gameObject.GetComponent<Text>().text = "Score: " + NewGameManager.firstPlayerScore;
        else
            gameObject.GetComponent<Text>().text = "Score: " + NewGameManager.secondPlayerScore;
    }
}
