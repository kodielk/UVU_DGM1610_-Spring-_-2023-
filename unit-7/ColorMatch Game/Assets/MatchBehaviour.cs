using UnityEngine;
using UnityEngine.Events;

public class MatchBehaviour : MonoBehaviour
{
    public ID idObj;
    public UnityEvent matchEvent, noMatchEvent;
    private void OnTriggerEnter(Collider other)
    {
        // Gets the component
        var tempObj = other.GetComponent<IDContainerBehaviour>();
        // run nothing if null
        if (tempObj == null)
            return;

        var otherID = tempObj.idObj;
        // If then for if there is or isn't a match
        if (otherID == idObj)
        {
            matchEvent.Invoke();
        }
        else
        {
            noMatchEvent.Invoke();
        }
    }
}