using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    public float verticalBounds;
    public float horizontalBounds;
    

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -horizontalBounds)
            Destroy(gameObject);
        if (transform.position.x > horizontalBounds)
            Destroy(gameObject);
        if (transform.position.z < -verticalBounds)
            Destroy(gameObject);
        if (transform.position.z > verticalBounds)
            Destroy(gameObject);
    }
}
