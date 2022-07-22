using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulletsHurt : MonoBehaviour
{
    //public ScriptableInt ScoreCount;
	public UnityEvent BulletHitEvent;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
		
		if (other.tag == "Enemy")
			BulletHitEvent.Invoke();
    }
}
