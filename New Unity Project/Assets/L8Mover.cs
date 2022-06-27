using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L8Mover : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 50f;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector3(0, -1, 0) * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);

    }
}
