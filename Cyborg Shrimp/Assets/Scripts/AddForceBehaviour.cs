using System;
using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class AddForceBehaviour : MonoBehaviour
{
  private Rigidbody rigid;
  public Vector3 forces, forces2;
  public float holdTime = 3f;
  public int counter = 10;
  public bool canRun;

  private IEnumerator Start()
  {
    rigid = GetComponent<Rigidbody>();

    while (counter > 0)
    {
      yield return new  WaitForSeconds(holdTime);
      rigid.AddForce(forces);
      counter--;
    }
    while (canRun)
    {
      yield return new  WaitForSeconds(holdTime);
      rigid.AddForce(forces2);
      
    }
  }
}
