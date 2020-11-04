using System;
using UnityEngine;
public class MoverScript : MonoBehaviour
{
 public float moveSpeed;
 private Vector3 moveDirection;

 public void Update()
 {
  if (Input.GetButton("Jump"))
  {
   moveDirection.x = moveSpeed * Time.deltaTime;
  }
  else
  {
   moveDirection.x = -moveSpeed * Time.deltaTime;
  }
  transform.Translate(moveDirection);
  
 }
}





//public float speed = 10.0f;
//public int count;
//public Vector3 rotationVector3;
//public string password;
//private void Update()
//{
//if (password == "OU812")
//{
 //   print("Password is correct");
//}
//rotationVector3.y = speed * Time.deltaTime;
//transform.Rotate(rotationVector3);
//}