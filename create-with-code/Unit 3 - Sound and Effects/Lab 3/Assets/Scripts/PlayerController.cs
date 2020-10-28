using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float verticalInput;
    private float horozontalInput;
    private float zBound = 9;
    private float speed = 5.0f;
    private Rigidbody playerRb;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horozontalInput = Input.GetAxis("Horizontal");
        playerRb.AddForce(speed * verticalInput * Vector3.forward);
        playerRb.AddForce(speed * horozontalInput * Vector3.right);
        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,-zBound);//Take - off to endless scroll
        }
        if (transform.position.z > zBound)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,zBound);//Add the - to endless scroll
        }
    }
}
