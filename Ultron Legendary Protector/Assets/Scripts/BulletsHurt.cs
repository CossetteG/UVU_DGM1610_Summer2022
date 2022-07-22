using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsHurt : MonoBehaviour
{
    public ScoreManager ScoreManager;
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
    
        if (other.gameObject.tag == "Enemy")
        {
            ScoreManager.AddToScore();
        }
    }
}
