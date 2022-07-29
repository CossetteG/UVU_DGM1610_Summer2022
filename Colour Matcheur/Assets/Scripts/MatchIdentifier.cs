using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchIdentifier : MonoBehaviour
{
    public ID myidobj;
    void OnTriggerEnter(Collider other)
    {
        var otherID = other.GetComponent<IDholder>().idobj;
        if (myidobj == otherID)
        {
            Debug.Log("Match");
        }
    }
}
