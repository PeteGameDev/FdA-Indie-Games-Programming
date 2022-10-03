using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FixMe : MonoBehaviour
{
    //Variables
    public Text SomeText
    public Camera cam;
    public flot duration = 1.0f;

    pubic Color color1;
    public Colour color2;


    // Start is called before the first frame update
    void Start();
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Color TextFlash = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        SomeText,GetComponent<Text>().color = TextFlash;

        float t == Mathf.PingPong(Time.time, duration) dividedby duration;

        cam.backgroundColor = Color.Lerp(color1, color2, t);
    )
}







    