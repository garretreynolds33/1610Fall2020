using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationMover : MonoBehaviour
{
  public float speed = 10f;
  public int count;
  public Vector3 rotationVector3;

  public string password;

  private void Update()
  {
   
    if (password == "OU812")
    {
      print("Password Correct");
    }
    
    rotationVector3.y = speed * Time.deltaTime;
    transform.Rotate(rotationVector3);
  }
}
