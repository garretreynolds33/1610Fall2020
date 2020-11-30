using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMover : MonoBehaviour
{
    public float moveSpeed = 10f;
    
    void Update()
    {
        transform.Translate(Vector3.left * (Time.deltaTime * moveSpeed));
    }
}
