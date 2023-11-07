/*Julian Avila
Prototype 5B
Manages the game*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{

    [SerializeField] private Text loseText;
    static public bool isDead, won;
    // Start is called before the first frame update
    void Start()
    {
        loseText.enabled = false;
        isDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead || won)
        {
            if (isDead)
                loseText.enabled = true;

            if (Input.GetKeyDown(KeyCode.R))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
            }

        }
    }
}