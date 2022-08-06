using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreTextUpdater : MonoBehaviour
{
    private Text label;
    public IntData intObj;

    private void Start()
    {
        label = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        //UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = intObj.number.ToString();
    }

    public void SetLabel(string letters)
    {
        label.text = letters;
    }
}
