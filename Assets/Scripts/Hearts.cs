using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject[] myHearts;
    public Sprite BlackHeart, RedHeart;
    void Start()
    {
      //  DeadHeart = Resources.Load<Sprite>("Resources/DeadHeart");
    }
    public void ChangeSprite(int sprNum, Sprite newSprite)
    {
        print("this is" + sprNum);
        myHearts[sprNum].GetComponent<SpriteRenderer>().sprite = newSprite;
    }
}
