using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    public GameObject kickMe;
    private void Start()
    {
        Destroy(kickMe, 3);
        Debug.Log("destroyed");
    }
}
