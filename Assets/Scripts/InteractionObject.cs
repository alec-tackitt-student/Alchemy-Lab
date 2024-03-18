
using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    public UnityEvent onInteract = new UnityEvent();
    [SerializeField] private string interactionText = "interactable Object";
  
    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {
       onInteract.Invoke();
    }
    
}
