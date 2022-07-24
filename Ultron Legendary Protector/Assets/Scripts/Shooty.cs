using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Shooty : MonoBehaviour
{
    public Transform blaster;
    public GameObject projectile;
    int ammoReference;
    public ScriptableInt AmmoCount;
    public UnityEvent ammoDownEvent;

    public GameOver gameOver;

    public void Update()
    {
        ammoReference = AmmoCount.number;
        if (ammoReference >= 1)
            Shooter();
        

    }

    public void Shooter()
    {
        if (Input.GetKeyDown(KeyCode.Space) && gameOver.stopp == 0)
        {
            Instantiate(projectile, blaster.transform.position, projectile.transform.rotation);
            ammoDownEvent.Invoke();
        }

    }

}
