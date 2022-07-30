using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    public UnityEvent StartEvent;
    public void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
        StartEvent.Invoke();
    }
    public void ColorChanger(ColorID obj)
    {
        rendererObj.color = obj.theColor;
    }
}
