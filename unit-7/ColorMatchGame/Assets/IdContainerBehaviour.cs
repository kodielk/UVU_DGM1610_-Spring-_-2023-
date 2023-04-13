using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IdContainerBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent startEvent;
    public void Start()
    {
        startEvent.Invoke();
    }
}