using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TImeManipulator : MonoBehaviour
{
    
    void Start()
    {
        Time.timeScale = 1;
    }

    public void StopTime()
    {
        Time.timeScale = 0;
    }

    public void GoTime()
    {
        Time.timeScale = 1;
    }
}
