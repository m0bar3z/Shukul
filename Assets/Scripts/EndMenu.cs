using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public Text HighScore, YourScore;
    public CatcherColor Scores;
    public int highScore, currentScore;
    void Start()
    {
        currentScore = PlayerPrefs.GetInt("CurrentScore");
        highScore = PlayerPrefs.GetInt("HighScore");
        HighScore = GameObject.FindGameObjectWithTag("HighScore").GetComponent<Text>();
        YourScore = GameObject.FindGameObjectWithTag("CurrentScore").GetComponent<Text>();
        YourScore.text = currentScore.ToString();
        HighScore.text = highScore.ToString();
    }
    public void PlayAgain()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
