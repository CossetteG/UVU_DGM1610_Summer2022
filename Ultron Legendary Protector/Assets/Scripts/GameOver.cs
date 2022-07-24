﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public GameObject world;
    public GameObject player1;

	public TextMeshProUGUI gameOverTxt;
	public string textSay;
	private string textControl = " ";

	public GameObject bbutton;
	public GameObject rbutton;

    public int stopp;

    void Start()
    {
        stopp = 0;
		gameOverTxt.text = textControl;
		if(stopp == 0)
		{
			bbutton.SetActive(false);
			rbutton.SetActive(false);
		}
    }

    void Update()
    {

        if (stopp == 0)
        {
            SayGameOver();
        }
    }

    void SayGameOver()
    {
        if (player1 == false)
        {
            GameOverScreen();
        }
        
        if (world == false)
        {
            GameOverScreen();
        }
		
    }
	public void GameOverScreen()
	{
		Time.timeScale = 0;
		Debug.Log("Game Over");
		stopp++;
		gameOverTxt.text = textSay;
		if (stopp >= 1)
		{
			bbutton.SetActive(true);
			rbutton.SetActive(true);
		}
		
	}
	
}
