using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class TextData : ScriptableObject
{
    public string words;

    public void SetValue(string txt)
    {
        words = txt;
    }
    
}
    
