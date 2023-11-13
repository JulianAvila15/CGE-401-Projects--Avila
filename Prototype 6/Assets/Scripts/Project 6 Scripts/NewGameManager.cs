using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NewGameManager : Singleton<NewGameManager>
{
    public static NewGameManager instance;
    public static bool gameOver,won;
    public int score;
    public static int firstPlayerScore, secondPlayerScore;

    public GameObject pauseMenu;

    //variable to keep track of what level we are on
    private string CurrentLevelName = string.Empty;


    private void Start()
    {
        score = firstPlayerScore = secondPlayerScore = 0;
        gameOver = false;
    }



    //methods to load and unload scenes
    public void LoadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(levelName,LoadSceneMode.Additive);

        if(ao==null)
        {
            Debug.LogError("[GameManager] Unable to load level"+levelName);
        }

        CurrentLevelName = levelName;


    }

    public void UnloadLevel(string levelName)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(levelName);

        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level" + levelName);
        }

        CurrentLevelName = levelName;


    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);

        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level" + CurrentLevelName);
        }

        


    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }

        if (gameOver == true && Input.GetKeyDown(KeyCode.R))
        {
            Start();
            UnloadCurrentLevel();
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level 4");

        }
    }

}
