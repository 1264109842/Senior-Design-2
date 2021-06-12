using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour
{
    Transform gameOverPanel;
    Transform winPanel;

    public static GameMode Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        gameOverPanel = canvas.transform.Find("GameOver");
        winPanel = canvas.transform.Find("WinPanel");

        //gameOverPanel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        gameOverPanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        ScoreScript.scoreValue = 0;
        SceneManager.LoadScene("SampleScene");
    }

    public void GameWin()
    {
        winPanel.gameObject.SetActive(true);
        Time.timeScale = 0;
    }
}
