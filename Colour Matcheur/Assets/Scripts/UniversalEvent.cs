using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UniversalEvent : MonoBehaviour
{
    public UnityEvent matchUni;
    public UnityEvent nomatchUni;

    public void MatchEventUni()
    {
        matchUni.Invoke();
    }

    public void NoMatchEventUni()
    {
        nomatchUni.Invoke();
    }
}
