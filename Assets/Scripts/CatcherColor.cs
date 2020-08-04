using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;
using UnityEngine.UI;

public class CatcherColor : MonoBehaviour
{
    public Sprite[] CatcherCOlors;
    public GameObject[] CandyinScene;
    public Health newHealth;
    public Text ScoreText;
    public int CurrentScore = 0, HighScore;
    public bool isScaled;
    
    void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        ScoreText.text = CurrentScore.ToString();
        newHealth = FindObjectOfType<Health>();
        HighScore = PlayerPrefs.GetInt("HighScore", HighScore);
    }

    public void AddScore()
    {
        CurrentScore++;
        PlayerPrefs.SetInt("CurrentScore", CurrentScore);
        ScoreText.text = CurrentScore.ToString();
        if (CurrentScore > HighScore)
        {
            HighScore = CurrentScore;
            PlayerPrefs.SetInt("HighScore",HighScore);
        }
    }
    
    public void ChangeColor()
    {
        int RandomNum = Random.Range(0, 5);
        this.GetComponent<SpriteRenderer>().sprite = CatcherCOlors[RandomNum];
    }
    public void ScaleCatcher()
    {
        if (isScaled == false && transform.localScale.x == 1)
        {
            transform.DOScale(new Vector3(2f, 2f, 1f), 1.5f);
            isScaled = true;
        }
        Invoke("reScaleCatcher", 4f);
    }

    public void reScaleCatcher()
    {
        if(isScaled == true && transform.localScale.x == 2)
        {
            transform.DOScale(new Vector3(1f, 1f, 1f), 2f);
            isScaled = false;
        }
    }

    public void DestroyCandies()
    {
        CandyinScene = GameObject.FindGameObjectsWithTag("Candy");
        foreach (GameObject Candy in  CandyinScene)
        {
            AddScore();
          //  print("candy found!! "+ CandyinScene.Length);
            Destroy(Candy);
        }
    } 

    
    void OnCollisionEnter2D(Collision2D collis)
    {
        if (collis.gameObject.tag == "Candy")
        {
            Destroy(collis.gameObject);
            AddScore();
            ChangeColor();   
        }

        if(collis.gameObject.tag == "GreenD")
        {
            Destroy(collis.gameObject);
            ScaleCatcher();
        }

        if (collis.gameObject.tag == "RedD")
        {
            Destroy(collis.gameObject);
            DestroyCandies();
        }

        if(collis.gameObject.tag == "Health")
        {
            Destroy(collis.gameObject);
            newHealth.AddHealth();
        }
    }
}
