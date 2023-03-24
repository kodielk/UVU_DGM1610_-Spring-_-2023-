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
        Debug.Log("You just got a point!");
        Debug.Log("Total points: " );
        Debug.Log(dataObj.value);
    }
}