using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Diamonds : MonoBehaviour
{
    public GameObject GreenDiamond;
    public GameObject RedDiamond;
    public GameObject Heart;

    float test;
    bool isLeft;
    float DurationTime, ExtraVelocity;
    void Start()
    {
     StartCoroutine(GreenDiamondSpawner());
     StartCoroutine(RedDiamondSpawner());
     StartCoroutine(Health());
    }

    void Update()
    {
        
        ExtraVelocity = (Time.time * -1 / 14);
        MoveAround();
    }

    public void MoveAround()
    {
        if (transform.position.x == 2.3f && isLeft == false)
        {
            transform.DOMoveX(-2.3f, 3f);
            isLeft = true;
        }

        if (transform.position.x == -2.3f && isLeft == true)
        {
            transform.DOMoveX(2.3f, 3f);
            isLeft = false;
        }
    }

    IEnumerator GreenDiamondSpawner()
    {
        yield return new WaitForSeconds(Random.Range(5, 7));
        while (true)
        {
            GameObject GreenD = Instantiate(GreenDiamond, transform.position, Quaternion.identity);
            GreenD.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, Random.Range(-1f, -3f) + ExtraVelocity);
            Destroy(GreenD, 14f);

            //yield return new WaitForSeconds(Random.Range(10f, 15f));
            yield return new WaitForSeconds(14f - test);
        }
    }

    //IEnumerator RedDiamondSpawner()
    //{
    //    yield return new WaitForSeconds(Random.Range(7f,10f));
    //    while (true)
    //    {
    //        GameObject RedD = Instantiate(RedDiamond, transform.position, Quaternion.identity);
    //        RedD.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, Random.Range(-2f.- 4f) + ExtraVelocity);
    //        Destroy(RedD, 14f);

    //        yield return new WaitForSeconds(Random.Range(11f, 14f));
    //    }
    //}

    IEnumerator RedDiamondSpawner()
    {
        yield return new WaitForSeconds(Random.Range(8, 10));
        while (true)
        {
            GameObject RedD = Instantiate(RedDiamond, transform.position, Quaternion.identity);
            RedD.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, Random.Range(-2f, -4f) + ExtraVelocity);
            Destroy(RedD, 14f);

            yield return new WaitForSeconds(Random.Range(11f, 14f));
        }
    }

    IEnumerator Health()
    {
        yield return new WaitForSeconds(Random.Range(11, 15));
        while (true)
        {
            GameObject HeartInstance = Instantiate(Heart, transform.position, Quaternion.identity);
            HeartInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, Random.Range(-1f, -3f) + ExtraVelocity);
            Destroy(HeartInstance,10f);

            yield return new WaitForSeconds(Random.Range(13, 15));
        }
    }

}
