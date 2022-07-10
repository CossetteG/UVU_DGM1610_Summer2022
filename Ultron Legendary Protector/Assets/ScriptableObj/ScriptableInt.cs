using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ScriptableInt : ScriptableObject
{
    public int number;

    public void UpdateInt(int num)
    {
        number += num;
        Debug.Log("Ammo Count: " + number);
    }

    /*private void Update()
    {
        if (number <= 0)
           noammo  = true;
        else
        {
            noammo = false;
        }
    }*/
    
}
