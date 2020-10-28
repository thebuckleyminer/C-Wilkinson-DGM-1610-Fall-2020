using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Private Variables
    [SerializeField] protected const float turnSpeed = 30.0f;
    [SerializeField] private readonly float speed = 25.0f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        //This gets the player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //This is the forward code
        transform.Translate(Time.deltaTime * speed * forwardInput * Vector3.forward);
        //This is the turning code
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
