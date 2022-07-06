using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class WordDataBehaviour : MonoBehaviour
{
    public Text werds;
    public TextData dataObjj;
    
    private void Start()
    {
        werds = GetComponent<Text>();
       
    }

    public void Update()
    {
        werds.text = dataObjj.words.ToString();
    }
}
