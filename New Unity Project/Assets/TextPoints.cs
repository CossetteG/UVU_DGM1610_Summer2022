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
        
    }

    public void Update()
    {
        ptText.text = ptInt.numberr.ToString();
    }
}
