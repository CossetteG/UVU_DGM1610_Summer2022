using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public float spaceBoundstop;
    public float spaceBoundsbottom;
    public GameObject enemy;
    public GameObject enemyC;
    public GameObject enemyB;
    public GameObject player1;
    private int stopp = 0;
    void Update()
    {
        if (enemy.transform.position.x >= spaceBoundsbottom)
            Debug.Log(" ");
        else if (enemy.transform.position.x <= spaceBoundstop)
                Debug.Log("Game Over");
        
        if (enemyC.transform.position.x >= spaceBoundsbottom)
            Debug.Log(" ");
        else if (enemyC.transform.position.x <= spaceBoundstop)
            Debug.Log("Game Over");
        
        if (enemyB.transform.position.x >= spaceBoundsbottom)
            Debug.Log(" ");
        else if (enemyB.transform.position.x <= spaceBoundstop)
            Debug.Log("Game Over");

        if (player1 == false)
            Debug.Log(" ");
        else if (stopp == 1)
        {
            Debug.Log("Game Over");
            stopp++;
        }

    }
}
