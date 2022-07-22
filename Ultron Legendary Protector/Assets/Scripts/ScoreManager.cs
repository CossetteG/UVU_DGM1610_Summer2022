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
    public int scoreAdder;
    public int score;
    public int ammo;

    public void Update()
    {
        score = ScoreCount.number;
        ammo = AmmoCount.number;
    }
    
    public void AddToScore()
        {
            ScoreCount.number += scoreAdder;
            UpdateScore();
        }
    
    public void UpdateScore()
        {
            scoretxt.text = "Score: " + score;
        }
    
}       
