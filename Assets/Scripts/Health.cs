using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public Hearts Heart;
    public int _health;
    
    void Start()
    {
        _health = 5;
        Heart = FindObjectOfType<Hearts>();
    }
    public void Losecandy()
    {
        _health--;
        if (_health == 0)
        {
            SceneManager.LoadScene("End");
        }
        Heart.ChangeSprite(_health,Heart.BlackHeart);
    }
    public void AddHealth()
    {
        if(_health < 5)
        {
            Heart.ChangeSprite(_health, Heart.RedHeart);
            _health++;
        }
    }

    
    private void OnTriggerEnter2D(Collider2D Collid)
    {
        if (Collid.gameObject.tag == "Candy")
        {
         //   print("this is candy");
            Losecandy();
        }
    }
}
