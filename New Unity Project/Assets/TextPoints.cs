using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class TextPoints : MonoBehaviour
{
    public Text ptText;
    public IntData ptInt;
    
    private void Start()
    {
        ptText = GetComponent<Text>();
        UpdateText();
    }

    public void UpdateText()
    {
        ptText.text = ptInt.numberr.ToString();
    }
}
