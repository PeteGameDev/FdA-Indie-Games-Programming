using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawn : MonoBehaviour
{
    public GameObject[] spawningObject;
    public Transform spawnPoint;

    
    void Start() {
        Physics.gravity = new Vector3(0, -9.81f, 0);
    }

    
    void Update() {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Spawn Object");
            GameObject clone = Instantiate(spawningObject[Random.Range(0, spawningObject.Length)], spawnPoint);
            clone.GetComponent<Renderer>().material.color = new Color (Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }
    }
}
