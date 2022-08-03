using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int number;
    public UnityEvent intEnd;

    public void SetValue(int num)
    {
        number = num;
    }

    public void SetHighScore(IntData obj)
    {
        if (obj.number >= number)
        {
            number = obj.number;
            Debug.Log(number);
        }
    }

    public void UpdateValue(int num)
    {
        number += num;
    }

    public void OnEnd()
    {
        intEnd.Invoke();
    }
}
