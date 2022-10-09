using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileExample : MonoBehaviour
{
    public GameObject spawningObject;
    public Transform spawnPoint;

    bool canSpawn = false;
    
    void Start()
    {
        do
        {
            GameObject clone = Instantiate(spawningObject, spawnPoint);
            clone.GetComponent<Renderer>().material.color = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
            
        }
        while(canSpawn == true);
    }
}
