using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawnScript : MonoBehaviour
{
    public GameObject[] spawnableObjects;
    public Transform[] spawnPoints;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = Instantiate(spawnableObjects[Random.Range(0, spawnableObjects.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)]);
            clone.GetComponent<Renderer>().material.color = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
        
    }

    
}
