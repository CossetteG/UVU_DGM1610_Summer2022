using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int numberr;

    public void SetValue(int num)
    {
        numberr = num;
    }
    public void UpdateNumber(int numb)
    {
        numberr += numb;
    }
}
