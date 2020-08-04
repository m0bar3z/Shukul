using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowingHighScore : MonoBehaviour
{
    public int highScore;
    public Text text;
    public CatcherColor Scores;
    
    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", highScore);
        text = gameObject.GetComponent<Text>();
        text.text = "HIghScore:   " + highScore.ToString();
        Invoke("Disabled", 2f);
    }

    void Update()
    {
        text.color = new Color(Random.Range(0f, 0.5f), Random.Range(0f, 0.5f), Random.Range(0f, 0.5f));
    }

    public void Disabled()
    {
        gameObject.SetActive(false);
    }
}
