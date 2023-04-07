using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject tipPanel;

    private void Awake()
    {
        instance = this;
    }

    public Transform playerTransform;



    private void Start()
    {
        Time.timeScale = 0;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            exitgame();
        }
        if (Input.GetKeyDown(KeyCode.F5))
        {
            RestartLevel();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Time.timeScale = 1;
            tipPanel.SetActive(false);
        }
    }
    public void EndGame()
    {

    }



    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void exitgame()
    {

        // Tắt game
        Application.Quit();
    }

    public void startgame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    public void returnToMenu()
    {

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
