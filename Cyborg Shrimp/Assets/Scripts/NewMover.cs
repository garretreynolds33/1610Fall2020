using UnityEngine;
using UnityEngine.UI;

public class NewMover : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 moveDirection;
    public float movespeed = 3f, gravity = -9.81f, jumpForce = 5f;
    private float yDirection;

    // Update is called once per frame
    void Update()
    {
        var moveSpeedInput = movespeed * Input.GetAxis("Horizontal");
        moveDirection.Set(moveSpeedInput, yDirection ,0);

        yDirection += gravity * Time.deltaTime;
        
        if (controller.isGrounded && moveDirection.y < 0)
        {
            yDirection = -1f;
        }
        

        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        
        controller.Move(moveDirection*Time.deltaTime);
    }
}
