using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetTransform : MonoBehaviour
{
    public Vector3 backPosition;
    public void TransformZero()
    {
        transform.position = Vector3.zero;
    }

    public void TransformHide(GameObject obj)
    {
        obj.transform.position = backPosition;
    }
}
