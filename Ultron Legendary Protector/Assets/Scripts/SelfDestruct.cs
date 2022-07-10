using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public Collider playerCol;
    private void OnTriggerEnter(Collider playerCol)
    {
        Destroy(gameObject); 
    }
}
