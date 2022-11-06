using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ExampleMovement : MonoBehaviour
{
    CharacterController controller;
    Vector2 moveDirection;
    PlayerInputActions playerInputActions;
    PlayerInput playerInput;
    float gravity = -9.81f;

    public float jumpHeight;
    public float moveSpeed;
   
    void Awake()
    {
        controller = GetComponent<CharacterController>();
        playerInput = GetComponent<PlayerInput>();

        playerInputActions = new PlayerInputActions();
        playerInputActions.Player.Enable();
        playerInputActions.Player.Jump.performed += Jump;
        playerInputActions.Player.Movement.performed += Move;
    }

    private void Update() {
        moveDirection = playerInputActions.Player.Movement.ReadValue<Vector2>();
        controller.Move(new Vector3(moveDirection.x, 0, moveDirection.y) * moveSpeed * Time.deltaTime);
    }

    public void Move(InputAction.CallbackContext context){
        if(context.performed){
            moveDirection = context.ReadValue<Vector2>();
            controller.Move(new Vector3(moveDirection.x, 0, moveDirection.y) * moveSpeed * Time.deltaTime);
            moveDirection.y += gravity * Time.deltaTime;
        }
    }

    public void Jump(InputAction.CallbackContext context){
        if(context.performed){
            Debug.Log("Jump" + context.phase);
            moveDirection.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }
}
