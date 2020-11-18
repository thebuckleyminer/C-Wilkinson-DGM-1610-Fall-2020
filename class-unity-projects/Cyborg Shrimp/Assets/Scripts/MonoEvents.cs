using System;
using UnityEngine;
using UnityEngine.Events;
public class MonoEvents : MonoBehaviour
{
    public UnityEvent awakeEvent, startEvent, onEnableEvent;

    private void Awake()
    {
        awakeEvent.Invoke();
    }

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.ToString();
    }
}
