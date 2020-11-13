using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 5f;

    private Vector3 moveDirection;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var movespeedinput = moveSpeed * Input.GetAxis("Vertical");
        moveDirection.Set(0,movespeedinput,0);

        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);
    }
}
