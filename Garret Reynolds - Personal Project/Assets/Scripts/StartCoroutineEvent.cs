using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class StartCoroutineEvent : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float holdTime = 1f, repeatHoldTime = 1f;
    public int counter = 3;
    public Text text;


    public void Start()
    {
        StartCoroutine(Coroutine());
    }
    

    private IEnumerator Coroutine()
    {
        startEvent.Invoke();
        
        yield return  new WaitForSeconds(holdTime);

        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return new WaitForSeconds(repeatHoldTime);
            counter--;
            text.text = counter.ToString();
            if (counter.Equals(0))
            {
                text.text = "Go!";
            }
        }
        yield return new WaitForSeconds(holdTime);
        endEvent.Invoke();

    }
}
