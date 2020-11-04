using System;
using UnityEngine;
public class MoverScript : MonoBehaviour
{
    public float speed = 5.0f;
    public int score = 100;
    public float buttonJumpDistance = 0.5f;
    private void Update()
    {
        var vInput = Time.deltaTime * speed * Input.GetAxis("Vertical");
        var hInput = Time.deltaTime * speed * Input.GetAxis("Horizontal");
        transform.Translate(hInput, vInput, 0);
    }
    public void Up()
    {
        transform.Translate(0, buttonJumpDistance, 0);
    }
    public void Down()
    {
        transform.Translate(0,-buttonJumpDistance,0);
    }
    
}
