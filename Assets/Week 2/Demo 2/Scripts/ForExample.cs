using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForExample : MonoBehaviour
{
    public GameObject spawningObject;
    public Transform spawnPoint;

    int numberOfBalls = 1;

    void Start()
    {
        for(int i = 0; i < numberOfBalls; i++)
        {
            GameObject clone = Instantiate(spawningObject, spawnPoint);
            clone.GetComponent<Renderer>().material.color = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }

    
    
}
