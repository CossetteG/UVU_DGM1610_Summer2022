﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int number;

    public void UpdateValue(int num)
    {
        number += num;
    }
}
