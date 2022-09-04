using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdScriptEver : MonoBehaviour
{
    Renderer cubeRenderer;
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //If the R key is pressed the colour should change to red
        if(Input.GetKeyDown(KeyCode.R))
        {
            //Change Colour to Red
            cubeRenderer.material.color = Color.red;
        }

    }
}
