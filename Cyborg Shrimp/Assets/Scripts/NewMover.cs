using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class NewMover : MonoBehaviour
{
   private CharacterController controller;
   public float movespeed = 5f, gravity = -9.81f, jumpForce = 10f;

   private Vector3 moveDirection;
   private float yDirection;

   private void Start()
   {
      controller = GetComponent<CharacterController>();
   }

   private void Update()
   {
      var movespeedinput = movespeed * Input.GetAxis("Horizontal");
      moveDirection.Set(movespeedinput,yDirection,0);

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
   }
}
