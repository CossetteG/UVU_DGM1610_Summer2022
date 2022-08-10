using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIdList : ScriptableObject
{
    public List<ColorID> value;

    public ColorID randomColor;
    public int cnum;

    public void SetColor()
    {
        cnum = Random.Range(0, value.Count);
        randomColor = value[cnum];
    }
}
