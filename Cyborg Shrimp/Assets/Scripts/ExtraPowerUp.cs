
using System;
using UnityEngine;

public class ExtraPowerUp : MonoBehaviour
{
    public int value = 10;

    private void OnTriggerEnter(Collider other)
    {
        value++;
        print(value);
    }
} 
