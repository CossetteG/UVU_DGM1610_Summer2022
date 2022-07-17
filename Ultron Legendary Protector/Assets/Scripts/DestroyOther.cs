using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOther : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
		if(other.gameObject.tag == "Player")
		{
			Destroy(other.gameObject);
		}
		if(other.gameObject.tag == "World")
		{
			Destroy(other.gameObject);
		}
    }
	
}
