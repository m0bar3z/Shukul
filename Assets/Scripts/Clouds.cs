using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    public GameObject[] myClouds;
    public Transform[] spawnPos;
    private int _randomSpawnPoint, _randomCloud;
    public bool DestInFirst = true;
    void Start()
    {
       StartCoroutine(Cloud1());
       StartCoroutine(Cloud2());
       StartCoroutine(Clouds3());
       StartCoroutine(Cloud4());
       StartCoroutine(Cloud5());
       StartCoroutine(Cloud6());
       StartCoroutine(Cloud7());
       StartCoroutine(Cloud8());
       //  StartCoroutine(OtherClouds());
    }

    void Update()
    {
    //  print(Time.time);
    }
    
    //Closer clouds
    IEnumerator Cloud1()
    {
        yield return new WaitForSeconds(1f);
                
        while (true)
        {   
            GameObject C1 = Instantiate(myClouds[0], spawnPos[0].transform.position, Quaternion.identity) as GameObject;
            Rigidbody2D Rig = C1.GetComponent<Rigidbody2D>();
            Rig.velocity = new Vector2(0f,Random.Range(15,18));
            //print(Rig.velocity);
            //Rig.gravityScale = -2f;
            
            Destroy(C1, 2f);
            
            yield return new WaitForSeconds(Random.Range(2,4));
        }
    }

    IEnumerator Cloud2()
    {
        yield return new WaitForSeconds(1.5f);
        
        while (true)
        {
            GameObject C1 = Instantiate(myClouds[0], spawnPos[2].transform.position, Quaternion.identity) as GameObject;
            Rigidbody2D Rig = C1.GetComponent<Rigidbody2D>();
            Rig.velocity = new Vector2(0f,Random.Range(17,20));
            

            Destroy(C1,2f);
            yield return new WaitForSeconds(Random.Range(2.5f,5f));
        }
        
    }

    IEnumerator Cloud7()
    {
        yield return new WaitForSeconds(2f);
        
        while (true)
        {
            GameObject Cl = Instantiate(myClouds[0], spawnPos[1].transform.position, Quaternion.identity);
            Rigidbody2D Rig = Cl.GetComponent<Rigidbody2D>();
            Rig.velocity = new Vector2(0f,Random.Range(16,20));

            Destroy(Cl,2f);
            yield return new WaitForSeconds(Random.Range(5.5f,7f));
        }
    }

    IEnumerator Cloud8()
    {
        yield return new WaitForSeconds(2.5f);
        
        while (true)
        {
            GameObject Cl = Instantiate(myClouds[0], spawnPos[3].transform.position, Quaternion.identity);
            Rigidbody2D Rig = Cl.GetComponent<Rigidbody2D>();
            Rig.velocity = new Vector2(0f,Random.Range(16f,20f));

            Destroy(Cl,2f);
            yield return  new WaitForSeconds(Random.Range(7.5f,9f));
        }
    }
    
    
    
    

    // Away Clouds
    IEnumerator Clouds3()
    {
        yield return new WaitForSeconds(3f);
        
        while (true)
        {       
            GameObject C1 = Instantiate(myClouds[1], spawnPos[1].transform.position, Quaternion.identity) as GameObject;
            Rigidbody2D Rig = C1.GetComponent<Rigidbody2D>();
            Rig.velocity = new Vector2(0f,Random.Range(8,12));

            Destroy(C1,1.5f);
            yield return new WaitForSeconds(Random.Range(1,3));
        }
    }

    IEnumerator Cloud4()
    {
        yield return new WaitForSeconds(3.5f);
        
        while (true)
        {
            GameObject Cl = Instantiate(myClouds[1], spawnPos[3].transform.position, Quaternion.identity);
            Rigidbody2D Rig = Cl.GetComponent<Rigidbody2D>();
            Rig.velocity = new Vector2(0f,Random.Range(8,12));

            Destroy(Cl,1.5f);
            
            yield return  new  WaitForSeconds(Random.Range(3.3f,5f));
        }
    }

    IEnumerator Cloud5()
    {
        yield return new WaitForSeconds(4f);
        
        while (true)
        {
            GameObject Cl = Instantiate(myClouds[1], spawnPos[0].transform.position,Quaternion.identity);
            Rigidbody2D Rig = Cl.GetComponent<Rigidbody2D>();
            Rig.velocity = new Vector2(0f,Random.Range(8,12));

            Destroy(Cl,3f);
            
            yield return  new WaitForSeconds(Random.Range(5.3f,7f));
        }
    }

    IEnumerator Cloud6()
    {
        yield return new WaitForSeconds(4.5f); 
        
        while (true)
        {
            GameObject Cl = Instantiate(myClouds[1],spawnPos[2].transform.position,Quaternion.identity);
            Rigidbody2D Rig = Cl.GetComponent<Rigidbody2D>();
            Rig.velocity = new Vector2(0f,Random.Range(8,12));
            
            Destroy(Cl,3f);
            
            yield return new WaitForSeconds(Random.Range(7.3f,9f));
        }
    }
        
        
    //Other clouds
    /*IEnumerator OtherClouds()
    {
        while (true)
        {
            _randomSpawnPoint = Random.Range(4, 6);
            _randomCloud = Random.Range(0, 2);
            print("this is randomcloud: " + _randomCloud + "  this is random pos: " + _randomSpawnPoint);
            GameObject Cl = Instantiate(myClouds[_randomCloud],
                spawnPos[_randomSpawnPoint].transform.position, Quaternion.identity);
            Rigidbody2D Rig = Cl.GetComponent<Rigidbody2D>();
            Rig.velocity = new Vector2(0f, Random.Range(7, 15));

            Destroy(Cl, 2.5f);

            yield return new WaitForSeconds(Random.Range(5, 10));
        }
    }*/
 }
