using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    //Public Variables
    public CharacterController controller;
    public float moveSpeed = 5.0f, gravity = -9.81f, jumpForce = 10f;
    
    
    //Private Variables
    private Vector3 moveDirection;
    private float yDirection;
    
    // This moves the player smoothly on the Horizontal axis and jumps
    private void Update()
    {
        
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput,yDirection,0);

        yDirection += gravity * Time.deltaTime;

        // This if statement pulls the gravity down at a constant speed if not falling.
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
    }
}

