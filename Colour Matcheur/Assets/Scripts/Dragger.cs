using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Dragger : MonoBehaviour
{
    public Camera cameraObj;
    public bool draggable;
    public Vector3 position;
    public Vector3 offset;
    public UnityEvent startDragEvent, stopDragEvent;
    void Start()
    {
        cameraObj = Camera.main;
    }

    public IEnumerator OnMouseDown()
    {
        //offset = transform.position - new Vector3(cameraObj.ScreenToWorldPoint(Input.mousePosition).x, cameraObj.ScreenToWorldPoint(Input.mousePosition).y, cameraObj.ScreenToWorldPoint(Input.mousePosition).z); 
        offset = new Vector3(6f, 4.918728f, 0f);
        draggable = true;
        yield return new WaitForFixedUpdate();
        
        while (draggable)
        {
            yield return new WaitForFixedUpdate();
            startDragEvent.Invoke();
            position = cameraObj.ScreenToViewportPoint(Input.mousePosition); 
            transform.position = position * 12 - offset;
            transform.position = new Vector3((transform.position.x * 1.74652934f), (transform.position.y * .8513153f), transform.position.z);
        }
    }

    private void OnMouseUp()
    {
        draggable = false;
        stopDragEvent.Invoke();
    }

}
