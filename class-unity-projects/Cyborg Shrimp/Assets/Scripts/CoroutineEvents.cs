﻿using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class CoroutineEvents : MonoBehaviour
{
    public UnityEvent startEvent, repeatEvent, endEvent;
    public float holdTime, repeatHoldTime = 0.25f;
    public int counter =3;

    public void RunCorutine()
    {
        StartCoroutine(Coroutine());
    }
    private IEnumerator Coroutine()
    {
        
        startEvent.Invoke();
        yield return new WaitForSeconds(holdTime);
        while (counter > 0)
        {
            repeatEvent.Invoke();
            yield return new WaitForSeconds(holdTime);
            counter--;
        }
        
        yield return new WaitForSeconds(holdTime);
        endEvent.Invoke();
    }

}
