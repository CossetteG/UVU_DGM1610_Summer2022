using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BulletsHurt : MonoBehaviour
{
	public UnityEvent BulletHitEvent;
	public GameObject enemyDestroySound;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Destroy(gameObject);
		
		if (other.tag == "Enemy")
		{
			BulletHitEvent.Invoke();
			Instantiate(enemyDestroySound, new Vector3(0,0,0), new Quaternion(0,0,0,0));
		}
		
    }
}
