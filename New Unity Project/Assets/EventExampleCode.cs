using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventExampleCode : MonoBehaviour
{
    private UnityEvent myEvent;
    
    // Start is called before the first frame update
    void Start()
    {
        if (myEvent == null)
            myEvent = new UnityEvent();
        myEvent.AddListener(Ping);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && myEvent != null)
            myEvent.Invoke();
    }

    void Ping()
    {
        Debug.Log("Ping");
    }
}
