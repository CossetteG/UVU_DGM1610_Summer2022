using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L10Destroy : MonoBehaviour
{
    public GameObject other;

    void Update()
    {
        if (Input.GetKey(KeyCode.J))
            Destroy(gameObject);

        if (Input.GetKey(KeyCode.K))
            Destroy(other);

        if (Input.GetKey(KeyCode.L))
            Destroy(GetComponent<MeshRenderer>());
    }
}
