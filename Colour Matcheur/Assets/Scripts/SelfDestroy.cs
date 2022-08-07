using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestroy : MonoBehaviour
{
    public float seconds = 1;
    private WaitForSeconds wafos;
    IEnumerator Start()
    {
        wafos = new WaitForSeconds(seconds);
        yield return wafos;
        Destroy(gameObject);
    }
    
}
