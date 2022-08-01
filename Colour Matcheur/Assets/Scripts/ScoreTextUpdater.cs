using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreTextUpdater : MonoBehaviour
{
    private Text label;

    private void Start()
    {
        label = GetComponent<Text>();
    }

    public void UpdateLabel(IntData obj)
    {
        label.text = obj.number.ToString();
    }
}
