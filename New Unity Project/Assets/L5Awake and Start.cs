using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L5AwakeandStart : MonoBehaviour
{
    //Awake is called before Start, best for initialization
    void Awake()
    {
        Debug.Log("Awake called");
    }
    
    
    // Start is called before the first frame update
    //Start must be activated
    void Start()
    {
        Debug.Log("Start called");
        
    }

    //like update but called regularly
    //used for physics
    void FixedUpdate()
    {
        
        Debug.Log("FixedUpdate time :" + Time.deltaTime);
    }
    
    // Update is called once per frame
    //Used for regular updates such as:
    //non physics movement, simple timers, receiving input
    void Update()
    {
        Debug.Log("Update time :" + Time.deltaTime);
        
    }
}
