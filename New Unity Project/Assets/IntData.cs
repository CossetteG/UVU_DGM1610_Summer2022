using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int numberr;

    public void UpdateNumber(int numb)
    {
        numberr += numb;
    }
}
