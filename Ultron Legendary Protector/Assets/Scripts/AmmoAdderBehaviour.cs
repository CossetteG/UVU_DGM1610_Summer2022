using UnityEngine; 
using UnityEngine.Events; 
 
public class AmmoAdderBehaviour : MonoBehaviour 
{ 
    public UnityEvent triggerEnterEvent;
    public ScoreManager scoreManager;
	public ScriptableInt AmmoCount;

    private void OnTriggerEnter(Collider other) 
    { 
        triggerEnterEvent.Invoke();
    } 
}
    

