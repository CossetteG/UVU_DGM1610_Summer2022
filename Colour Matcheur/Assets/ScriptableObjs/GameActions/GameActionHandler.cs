using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class GameActionHandler : MonoBehaviour
{
    public GameAction gameActionObj;
    public UnityEvent onRaiseEvent;
    void Start()
    {
        gameActionObj.raise += Raise;
    }

    public void Raise()
    {
        onRaiseEvent.Invoke();
    }
    
}
