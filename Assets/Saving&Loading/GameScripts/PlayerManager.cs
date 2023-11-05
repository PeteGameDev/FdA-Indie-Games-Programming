using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerManager : MonoBehaviour, IDataPersistence
{
    #region Variables
    public float speed;
    public int score = 0;
    public TMP_Text scoreText;
    CharacterController controller;
    Vector3 moveDirection;
    #endregion


    void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    void Update()
    {
        Move();
        scoreText.SetText(score.ToString());
    }

    public void LoadData(GameData data){
        this.score = data.score;
        this.transform.position = data.playerPosition;
    }

    public void SaveData(ref GameData data){
        data.score = this.score;
        data.playerPosition = this.transform.position;
    }

    #region GameStuff
    void Move(){
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertcial = Input.GetAxisRaw("Vertical");

        moveDirection = (moveHorizontal * transform.right + moveVertcial * transform.forward);

        controller.Move(moveDirection * speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        if(other.CompareTag("ScoreObject")){
            score++;
            Destroy(other.gameObject);
        }
    }
    #endregion
}
