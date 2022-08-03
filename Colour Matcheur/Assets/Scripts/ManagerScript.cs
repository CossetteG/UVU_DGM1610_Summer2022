using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ManagerScript : MonoBehaviour
{
    //public IntData score;
    public bool gameEnd = false;
    public UnityEvent endEvent;

    public void Update()
    {
        /*if (Input.GetKey(KeyCode.P))
            {
                gameEnd = true;
                endEvent.Invoke();
            }*/
        
    }

    private void OnDisable()
    {
        gameEnd = true;
        endEvent.Invoke();
    }
}
