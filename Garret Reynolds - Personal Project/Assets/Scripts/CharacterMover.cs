using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    private float moveSpeed = 7f;
    private float yRange = 5f;
    private Vector3 moveDirection;

    public GameObject laserPrefab;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var verticalmovement = moveSpeed * Input.GetAxis("Vertical");
        var horizontalmovement = moveSpeed * Input.GetAxis("Horizontal");
        
        moveDirection.Set(horizontalmovement,verticalmovement,0);

        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);

        if (transform.position.y > yRange)
        {
            transform.position = new Vector3(transform.position.x, yRange, transform.position.z);
            
        } else if (transform.position.y < -yRange)
        {
            transform.position = new Vector3(transform.position.x, -yRange, transform.position.z);
            
        }

        if (transform.position.x > -8)
        {
            transform.position = new Vector3(-8, transform.position.y, transform.position.z);
        } else if (transform.position.x < -13)
        {
            transform.position = new Vector3(-13, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefab, new Vector3(transform.position.x+3, transform.position.y, 0), laserPrefab.transform.rotation);
        }
    }
}
