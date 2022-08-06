using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    public Vector3Data v3Obj;
    public void InstantiateObject()
    {
        Instantiate(prefab);
    }

    public void InstantiateWithVector3()
    {
        Instantiate(prefab, v3Obj.number, Quaternion.identity);
    }
}
