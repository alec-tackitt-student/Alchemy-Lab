
using UnityEngine;
using UnityEngine.Events;

public class InteractionObject : MonoBehaviour
{
    public UnityEvent
    // Start is called before the first frame update
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        
    }

    [SerializeField] private string interactionText = "interactable Object";

    public string GetInteractionText()
    {
        return interactionText;
    }

    public void Interact()
    {
        print("interaction");
    }
}
