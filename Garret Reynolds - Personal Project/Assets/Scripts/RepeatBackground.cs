using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private float rotateSpeed = 15f;
    
    void Update()
    {
        transform.Rotate(0,rotateSpeed* Time.deltaTime,0);
    }
}
