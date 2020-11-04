using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    //Public Variables
    public CharacterController controller;
    public float moveSpeed = 5.0f, gravity = -9.81f, jumpForce = 5.0f;
    //Private Variables
    private Vector3 moveDirection;
    private float yDirection;
    private void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal"); // This is going to make it so our character can go left and right when they push the buttons
        moveDirection.Set(moveSpeedInput,yDirection,0);
        yDirection += gravity * Time.deltaTime;
        if (controller.isGrounded && moveDirection.y < 0)
        {
            yDirection = -1f;
        }
        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);

        //Old Code:
        //var movement = moveDirection * Time.deltaTime; // We put this here because you should not pass calculations
        //controller.Move(movement);
    }
}

