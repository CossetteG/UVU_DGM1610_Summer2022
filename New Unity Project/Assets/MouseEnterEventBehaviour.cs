using UnityEngine;
using UnityEngine.Events;

public class MouseEnterEventBehaviour : MonoBehaviour
{
    public UnityEvent mouseEnterEvent;

    private void OnMouseEnter(Collider other)
    {
        mouseEnterEvent.Invoke();
    }
}
