using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public int ammo;

    private void OnTriggerEnter(Collider other)
    {
        ammo++;
           print(ammo);
    }
}
