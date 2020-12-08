using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{
    private float bound = 16f;
    void Update()
    {
        if (transform.position.x > bound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -bound)
        {
            Destroy(gameObject);
        }
    }
}
