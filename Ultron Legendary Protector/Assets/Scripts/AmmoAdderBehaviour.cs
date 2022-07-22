using UnityEngine; 
using UnityEngine.Events; 
 
public class AmmoAdderBehaviour : MonoBehaviour 
{ 
    public UnityEvent triggerEnterEvent;
    public ScoreManager ScoreManager;

    private void OnTriggerEnter(Collider other) 
    { 
        triggerEnterEvent.Invoke();
        UpdateAmmo();

    }
    private void UpdateAmmo()
    {
        ScoreManager.ammotxt.text = "Ammo: " + ScoreManager.ammo;
    }
}
    

