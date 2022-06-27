using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L7Activating : MonoBehaviour
{
    public GameObject myObject;
    
    // Start is called before the first frame update
    //not tested
    void Start()
    {
        gameObject.SetActive(false);
        
        Debug.Log("Active Self: " + myObject.activeSelf);
        Debug.Log("Active in Hierarchy" + myObject.activeInHierarchy);
    }

    
}
