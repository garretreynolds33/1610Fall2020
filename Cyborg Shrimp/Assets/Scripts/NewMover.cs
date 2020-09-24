using UnityEngine;

public class NewMover : MonoBehaviour
{
   public CharacterController controller;
   public float movespeed = 5f, gravity = -9.81f, jumpForce = 10f;

   private Vector3 moveDirection;
   private float yDirection;
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
