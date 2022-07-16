using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject world;
    public GameObject player1;

    private int stopp;
    void Start()
    {
        stopp = 0;
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
            stopp++;
        }
        
        if (world == false)
        {
            Debug.Log("Game Over");
            stopp++;
        }
    }
}
