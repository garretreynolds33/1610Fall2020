using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public float speed = 3f, x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var vInput = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        var hInput = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        transform.Translate(x,y,z);
    }

    public void Up()
    {
        transform.Translate(0, speed, 0);
    }
    public void Down()
    {
        transform.Translate(0, -speed, 0);
    }
}

