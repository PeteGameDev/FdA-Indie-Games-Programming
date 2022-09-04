using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondScriptEver : MonoBehaviour
{
    int speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Current Speed = " + speed);
    }

    // Update is called once per frame
    void Update()
    {
        //Rotate the object around the X axis
        transform.Rotate(Vector3.right * speed * Time.deltaTime);
        //Rotate the object around the Y axis
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
