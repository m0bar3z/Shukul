using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        
    }

    void Update()
    {
        
        Vector3 MousePosInBlocks = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //print("this is view to screenpoint: " + Camera.main.ViewportToScreenPoint(new Vector3(1f, 1f, 0f)));
        //  transform.position = new Vector3(MousePosInBlocks.x , MousePosInBlocks.y , this.transform.position.z);
        //  this.transform.rotation = Quaternion.Euler
        //  this.transform.position = Vector2.Lerp(this.transform.position, MousePosInBlocks, 0.7f);
        transform.DOMove(new Vector3(MousePosInBlocks.x, MousePosInBlocks.y, transform.position.z), 0.2f);
        //transform.DORotate(new Vector3(0f, 0f, 0f), 1f);
        //transform.DOLookAt(new Vector3(0f, 0f, Input.mousePosition.z), 0.2f);
        //var Dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        //var Angle = Mathf.Atan2(Dir.y, Dir.x) * Mathf.Rad2Deg;
        
        //transform.rotation = Quaternion.AngleAxis(Angle, Vector3.forward);
        //transform.DOLookAt(Dir, 0.2f);
        //print(MousePosInBlocks);
    }
}
