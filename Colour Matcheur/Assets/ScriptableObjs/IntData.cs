using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int number;

    public void SetValue(int num)
    {
        number = num;
    }

    public void UpdateValue(int num)
    {
        number += num;
    }
}
