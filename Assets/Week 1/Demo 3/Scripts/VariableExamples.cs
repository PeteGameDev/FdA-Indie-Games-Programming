using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[AddComponentMenu("Example Menu/Example Script")]
public class VariableExamples : MonoBehaviour
{

    [Header("Variables you can change")]
    [Range(1,10)] public int anInt;
    public float anFloat;
    public bool anBool;
    
    [Header("Click the variable name")]
    [ContextMenuItem("Get a random string", "GenerateString")]
    public string anString;

    [Header("DON'T CHANGE THESE")]
    public Text intResult;
    public Text floatResult;
    public Text boolResult;
    public Text stringResult;

    Vector3 scaleChange;
    GameObject cube;
    Renderer cubeRenderer;
    

    void Start()
    {
        cube = GameObject.Find("Cube");
        cubeRenderer = cube.GetComponent<Renderer>();
    }

    
    void Update()
    {
        //Print variable results to screen
        intResult.text = anInt.ToString();
        floatResult.text = anFloat.ToString();
        stringResult.text = anString;
        

        //Using variables to create magic
        scaleChange = new Vector3(anInt, anInt, anInt);
        transform.localScale = scaleChange;

        transform.Rotate(Vector3.right * anFloat * Time.deltaTime);
        transform.Rotate(Vector3.up * anFloat * Time.deltaTime);

        if(anBool == true){
            cubeRenderer.material.color = Color.red;
            boolResult.text = "true";
        } else{
            cubeRenderer.material.color = Color.magenta;
            boolResult.text = "false";
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            GenerateString();
        }
    }

    void GenerateString()
    {
        anString = "";
        const string glyphs = "abcdefghijklmnopqrstuvwxyz0123456789";
        int charAmount = Random.Range(0, 30);
        for(int i = 0; i < charAmount; i++)
        {
            anString += glyphs[Random.Range(0, glyphs.Length)];
        }
    }
}
