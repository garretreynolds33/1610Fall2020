using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartCoroutineEvent : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float holdTime = 1f, repeatHoldTime;
    public int counter = 3;

    public void RunCoroutine()
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
        }
    }
}
