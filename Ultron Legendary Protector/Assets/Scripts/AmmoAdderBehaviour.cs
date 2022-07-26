using UnityEngine; 
using UnityEngine.Events; 
 
public class AmmoAdderBehaviour : MonoBehaviour 
{ 
    public UnityEvent triggerEnterEvent;
	public ScriptableInt AmmoCount;
	public GameObject powerUpSound;

    private void OnTriggerEnter(Collider other) 
    { 
        triggerEnterEvent.Invoke();
		Instantiate(powerUpSound, new Vector3(0,0,0), new Quaternion(0,0,0,0));
    } 
}
    

