using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnee;
    private float spawnTime = 1;
    private float spawnDelay = 1;
    private int randomInt;
    float positionX;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObject", spawnTime, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
       spawnTime = Random.Range(1, 3);
    }

    void spawnObject()
    {
        randomInt = Random.Range(0, spawnee.Length);
        positionX = Random.Range(8f,-8f);
        this.transform.position = new Vector3(positionX,transform.position.y , transform.position.z);
        Instantiate(spawnee[randomInt], transform.position, transform.rotation);
    }
}