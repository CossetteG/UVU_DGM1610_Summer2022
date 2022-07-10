using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AmmoDown : MonoBehaviour
{
    public UnityEvent ammoDownEvent;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            ammoDownEvent.Invoke();

    }
}
