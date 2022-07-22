using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoretxt;
    public TextMeshProUGUI ammotxt;

    public ScriptableInt AmmoCount;
    public ScriptableInt ScoreCount;

    public void Start()
    {
        AmmoCount.number = 5;
        ScoreCount.number = 0;
    }

    public void Update()
    {
        scoretxt.text = "Score: " + ScoreCount.number;
        ammotxt.text = "Ammo: " + AmmoCount.number;

    }
    
}       
