using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveCandySpawnPoint : MonoBehaviour
{
    public float DurationTime;
     bool LeftSide;
    
    void Update()
    {
        if (DurationTime > 1f)
        {
            DurationTime = DurationTime - (Time.deltaTime / 100);
        }
       MoveAround();
    }

    public void MoveAround()
    {    
        if(transform.position.x == 2.3f && LeftSide == false)
        {

            // print(Vector2.left);
            // transform.Translate(Vector2.left * -MoveSpeed * Time.deltaTime);
            transform.DOMoveX(-2.3f, DurationTime);
            LeftSide = true;
        } 

        if(transform.position.x == -2.3f && LeftSide == true)
        {
      
            transform.DOMoveX(2.3f,DurationTime);
            LeftSide = false;
        }
    }

}
