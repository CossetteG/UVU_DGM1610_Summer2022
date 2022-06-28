using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L11KeyInput : MonoBehaviour
{


    public float hRange;
    public float vRange;

    
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.F);
        bool held = Input.GetKey(KeyCode.F);
        bool up = Input.GetKeyUp(KeyCode.F);
        
        if(down)
            GetComponent<Renderer> ().material.color = Color.white;
        else if (held)
            GetComponent<Renderer>().material.color = Color.blue;
        else if (up)
            GetComponent<Renderer>().material.color = Color.grey;
        else
        {
            GetComponent<Renderer>().material.color = Color.red;
        }

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xPos, yPos, 0);
    }
}
