using System.Collections;
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

    private int stopp;

    void Start()
    {
        stopp = 0;
		gameOverTxt.text = textControl;
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
            Debug.Log("Game Over");
            Time.timeScale = 0;
            stopp++;
			TextChange();
        }
        
        if (world == false)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
            stopp++;
			TextChange();
        }
		
    }
	public void TextChange()
	{
		gameOverTxt.text = textSay;
	}
}
