using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    public float enemySpeed;
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * enemySpeed * Time.deltaTime);
    }
}
