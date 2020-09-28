using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public static float time;
    public float timeLastPass = 0f;

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            time = Time.time;
            float deltaTime = time - timeLastPass;
            if (deltaTime > .5f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                timeLastPass = time;
            }
            
        }
    }
    
}
