using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class TriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public FloatData dataObj;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
        Debug.Log("You just picked up a fish!");
        Debug.Log("Total fish collected: " );
        Debug.Log(dataObj.value);
    }
}