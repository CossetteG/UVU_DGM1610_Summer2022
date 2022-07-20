using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    
    public float xrange = 17f;

    void Update() 
    { 
        
        if (Input.GetKey(KeyCode.RightArrow)) 
            transform.Translate(new Vector3(1, 0, 0) * moveSpeed * Time.deltaTime); 
        if (Input.GetKey(KeyCode.LeftArrow)) 
            transform.Translate(new Vector3(-1, 0, 0) * moveSpeed * Time.deltaTime);

        if (transform.position.x < -xrange)
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        if (transform.position.x > xrange)
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); 
    }
    
    
}
