
using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    public UnityEvent onInteract = new UnityEvent();
    [SerializeField] private string interactionText = "interactable Object";
   

    
    // Start is called before the first frame update
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {
       onInteract.Invoke();
    }
    
}