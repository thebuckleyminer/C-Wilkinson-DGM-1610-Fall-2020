using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerController : MonoBehaviour
{
    //Private Variables
    private float turnSpeed = 25.0f;
    [SerializeField]private float speed = 25.0f;
    [SerializeField] private float horsePower = 0.0f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    public float rpm;
    public List<WheelCollider> allWheels;
    public int wheelsOnGround;


    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }


    void FixedUpdate()
    {
        //This gets the player input
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //This is the forward code
        //transform.Translate(Time.deltaTime * speed * verticalInput * Vector3.forward);
        //This is the turning code

        if (IsOnGround())
        {
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
            playerRb.AddRelativeForce(horsePower * verticalInput*Vector3.forward);

            speed = Mathf.RoundToInt(playerRb.velocity.magnitude * 2.237f);
            speedometerText.SetText("Speed: "+ speed + " MPH");
            rpm = (speed % 30)*40;
            rpmText.SetText("RPM: "+rpm);
        }

    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
