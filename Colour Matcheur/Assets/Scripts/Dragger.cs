using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Dragger : MonoBehaviour
{
    public Camera cameraObj;
    public bool draggable;
    public Vector3 position;
    public Vector3 offset, offsetter;
    public UnityEvent startDragEvent, stopDragEvent;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        offsetter = cameraObj.ScreenToWorldPoint(Input.mousePosition);
        //offset = transform.position - new Vector3(-offsetter.x, -offsetter.y, offsetter.z); 
        draggable = true;
        yield return new WaitForFixedUpdate();
        
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            startDragEvent.Invoke();
            offset = transform.position - new Vector3(offsetter.x, offsetter.y, offsetter.z); 
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition); 
            transform.position = position;
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        stopDragEvent.Invoke();
    }

}
