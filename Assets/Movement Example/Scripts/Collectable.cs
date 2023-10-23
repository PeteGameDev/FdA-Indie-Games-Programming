using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{
    public int score;
    public TMP_Text scoreText;
    public GameObject GameOverPanel;

    public Slider slider;

    void Update(){
        scoreText.SetText(score.ToString());
        if(score == 7){
            GameOverPanel.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("Collectable")){
            Debug.Log("Item collected");
            score++;
            Destroy(other.gameObject);
        }
    }
}
