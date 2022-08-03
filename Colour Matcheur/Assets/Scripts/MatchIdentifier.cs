using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MatchIdentifier : MonoBehaviour
{
    public ID myidobj;
    public UnityEvent MatchEvent, NoMatchEvent, NoMatchDelayed;
    public AudioSource audiclip;
    public IEnumerator OnTriggerEnter(Collider other)
    {
        var otherIdHolder = other.GetComponent<IDholder>();

        if (otherIdHolder == null)
        {
            Debug.Log("Set Color");
            yield break;
        }

        var otherID = otherIdHolder.idobj;
            
        if (myidobj == otherID)
        {
            MatchEvent.Invoke();
            Debug.Log("Match");
            yield break;
        }
        else if (myidobj != otherID)
        {
            NoMatchEvent.Invoke();
            Debug.Log("Not a Match");
            audiclip.Play();
            yield return new WaitForSeconds(0.5f);
            NoMatchDelayed.Invoke();
        }
    }
}
