using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    public GameObject myCandy;
    public Transform[] CandySpawnPoint;
    private float AddVelocity;
    void Start()
    {
        StartCoroutine(Candy1());
        StartCoroutine(Candy2());
        StartCoroutine(Candy3());
        StartCoroutine(Candy4());
    }

    
    void Update()
    {
        AddVelocity = (Time.timeSinceLevelLoad * -1) / 8;
        //print(AddVelocity);
       
    }

    IEnumerator Candy1()
    {
        yield return new WaitForSeconds(1f);
        while (true)
        {
            GameObject CandyInstance = Instantiate(myCandy, CandySpawnPoint[0].transform.position, Quaternion.identity);
            CandyInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, Random.Range(-3,-5) + AddVelocity);
            CandyInstance.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(150,400);
            Destroy(CandyInstance, 6f);

            yield return new WaitForSeconds(Random.Range(3f, 4f));
        }
    }

    IEnumerator Candy2()
    {
        yield return new WaitForSeconds(2.5f);
        while (true)
        {
            GameObject CandyInstance = Instantiate(myCandy, CandySpawnPoint[1].transform.position, Quaternion.identity);
            CandyInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, Random.Range(-5,-7) + AddVelocity);
            CandyInstance.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(150, 400);
            Destroy(CandyInstance,6f);

            yield return new WaitForSeconds(Random.Range(2.5f, 4f));
        }
    }

    IEnumerator Candy3()
    {
        yield return new WaitForSeconds(3f);
        while(true)
        {
            GameObject CandyInstance = Instantiate(myCandy, CandySpawnPoint[2].transform.position, Quaternion.identity);
            CandyInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,Random.Range(-3.5f,-5.5f) + AddVelocity);
            CandyInstance.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(150,400);
            Destroy(CandyInstance,6f);

            yield return new WaitForSeconds(Random.Range(2f,4f));
        }
    }

    IEnumerator Candy4()
    {
        yield return new WaitForSeconds(1.8f);
        while(true)
        {
            GameObject CandyInstance = Instantiate(myCandy, CandySpawnPoint[3].transform.position, Quaternion.identity);
            CandyInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,Random.Range(-5.3f,-7.5f) + AddVelocity);
            CandyInstance.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(150,400);
            Destroy(CandyInstance,6f);

            yield return new WaitForSeconds(Random.Range(1.5f,3.5f));
        }
    }

    IEnumerator Candy5()
    {
        yield return new WaitForSeconds(0.5f);
        while(true)
        {
            GameObject CandyInstance = Instantiate(myCandy, CandySpawnPoint[4].transform.position, Quaternion.identity);
            CandyInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0f,Random.Range(-4.2f,-6.2f) + AddVelocity);
            CandyInstance.GetComponent<Rigidbody2D>().angularVelocity = Random.Range(150,400);
            Destroy(CandyInstance,6f);

            yield return new WaitForSeconds(Random.Range(2.3f,4f));
            
        }
    }

}
