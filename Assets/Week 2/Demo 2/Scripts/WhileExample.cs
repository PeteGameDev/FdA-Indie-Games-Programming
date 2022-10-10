using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileExample : MonoBehaviour
{
    
    public GameObject spawningObject;
    public Transform spawnPoint;

    int numberOfBalls = 100;

    void Start()
    {
        while(numberOfBalls > 0)
        {
            GameObject clone = Instantiate(spawningObject, spawnPoint);
            clone.GetComponent<Renderer>().material.color = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            numberOfBalls--;
        }
    }

    void Update() {
        Debug.Log(numberOfBalls);
    }

    

}
