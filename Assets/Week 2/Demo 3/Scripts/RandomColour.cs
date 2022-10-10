using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColour : MonoBehaviour
{
    public Color32[] Colors;
    public GameObject colorObject;

    void Update(){
        if(Input.GetKeyDown(KeyCode.PageDown)){
        colorObject.GetComponent<Renderer>().material.color = Colors[Random.Range(0, Colors.Length)];
        }

    }
}
