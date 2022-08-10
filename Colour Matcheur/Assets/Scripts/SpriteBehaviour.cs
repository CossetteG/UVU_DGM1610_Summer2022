using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehaviour : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    public IDholder idObj;
    public MatchIdentifier matchIdObj;
    public UnityEvent StartEvent;
    public Color defaultColor;
    public void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
        idObj = GetComponent<IDholder>();
        matchIdObj = GetComponent<MatchIdentifier>();
    }

    public void Start()
    {
        StartEvent.Invoke();
    }
    public void ColorChanger(ColorID obj)
    {
        rendererObj.color = obj.theColor;
    }

    public void ColorChangerFromList(ColorIdList obj)
    {
        rendererObj.color = obj.randomColor.theColor;
        idObj.idobj = obj.randomColor;
        matchIdObj.myidobj = obj.randomColor;
    }
    
}
