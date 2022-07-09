using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileBehaviour : MonoBehaviour
{
    public float projectileSpeed = 15f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 1, 0) * projectileSpeed * Time.deltaTime);
    }
}
