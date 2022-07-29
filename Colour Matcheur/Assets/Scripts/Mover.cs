using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float moveSpeed;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(new Vector3(0, 1, 0) * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.S))
            transform.Translate(new Vector3(0, -1, 0) * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.D))
            transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime);
        if (Input.GetKey(KeyCode.A))
            transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);
    }
}
