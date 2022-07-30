using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchIdentifier : MonoBehaviour
{
    public ID myidobj;
    public UnityEvent MatchEvent, NoMatchEvent;
    void OnTriggerEnter(Collider other)
    {
        var otherIdHolder = other.GetComponent<IDholder>();

        if (otherIdHolder == null)
        {
            Debug.Log("Set Color");
            return;
        }

        var otherID = otherIdHolder.idobj;
            
        if (myidobj == otherID)
        {
            MatchEvent.Invoke();
            Debug.Log("Match");
        }
        else if (myidobj != otherID)
            Debug.Log("Not a Match");
    }
}
