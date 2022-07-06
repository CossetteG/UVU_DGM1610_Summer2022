using UnityEngine;
using UnityEngine.Events;

public class MouseOverEventBehaviour : MonoBehaviour
{
    public UnityEvent mouseOverEvent;

    private void OnMouseOver(Collider other)
    {
        mouseOverEvent.Invoke();
    }
}
