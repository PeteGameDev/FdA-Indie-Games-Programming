using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
    CharacterController controller;
    Vector3 moveDirection;
    Vector3 velocity;

    public float speed;
    public float jumpHeight;
    public float gravity;
    
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked; 
        if(controller.isGrounded){
            gravity = -1f;
        }
        else gravity = -9.81f;
        Move();
        if(Input.GetKeyDown("space") && controller.isGrounded){
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    void Move(){
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        float moveVertical = Input.GetAxisRaw("Vertical");
        moveDirection = (moveHorizontal * transform.right + moveVertical * transform.forward);
        controller.Move(moveDirection * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime); 

    }
}
