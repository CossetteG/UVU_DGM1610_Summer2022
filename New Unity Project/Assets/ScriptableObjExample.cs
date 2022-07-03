using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[CreateAssetMenu]
public class ScriptableObjExample : ScriptableObject
{
    public UnityEvent onZeroEvent;

    public float value1;

    public void UpdateValue(float num)
    {
        value1 += num; 
    }

    public void ReplaceValue(float num)
    {
        value1 = num;
    }

    public void DisplayImage(Image img)
    {
        if (value1 <= 0)
            onZeroEvent.Invoke();
        else if (value1 >= 1)
            value1 = 1;

        img.fillAmount = value1;
    }

    public void DisplayNumber(Text txt)
    {
        txt.text = value1.ToString();
    }
}
