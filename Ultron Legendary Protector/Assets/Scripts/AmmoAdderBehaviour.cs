using UnityEngine; 
using UnityEngine.Events; 
 
public class AmmoAdderBehaviour : MonoBehaviour 
{ 
    public UnityEvent triggerEnterEvent;

    private void OnTriggerEnter(Collider other) 
    { 
        triggerEnterEvent.Invoke(); 
    }


}
    

