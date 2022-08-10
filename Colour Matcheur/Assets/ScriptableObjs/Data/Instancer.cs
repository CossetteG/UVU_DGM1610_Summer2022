using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Instancer : ScriptableObject
{
    public GameObject prefab;
    public Vector3Data v3Obj;
    public V3DList vectorList, vectorList2;
    public PrefabList prefabList;
    private int num = 0;
    private int num2 = 0;

    public void InstantiateObject()
    {
        Instantiate(prefab);
    }

    public void InstantiateWithVector3()
    {
        Instantiate(prefab, v3Obj.number, Quaternion.identity);

    }

    public void InstantiateMultipleWithVector3()
    {
        foreach (var t in vectorList.value)
        {
            Instantiate(prefab, t.number, Quaternion.identity);
        }
    }

    public void InstantiateConditioned()
    {
        Instantiate(prefab, vectorList.value[num].number, Quaternion.identity);
        num++;
        if (num == vectorList.value.Count)
            num = 0;
    }

    public void InstantiateRandomPosition()
    {
        num = Random.Range(0, vectorList.value.Count);
        num2 = Random.Range(0, prefabList.value.Count);
        Instantiate(prefabList.value[num2], vectorList.value[num].number, Quaternion.identity);
    }

    public void InstantiateConditionedMultiple()
    {

        num = Random.Range(0, vectorList.value.Count);
        num2 = Random.Range(0, vectorList2.value.Count);
        Instantiate(prefabList.value[0], vectorList.value[num].number, Quaternion.identity);
        Instantiate(prefabList.value[1], vectorList2.value[num2].number, Quaternion.identity);
    }
}