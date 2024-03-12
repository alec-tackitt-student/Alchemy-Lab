using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    [SerializeField] private float m_distance = 2f;
    [SerializeField] private Text interactableName;

    private InteractionObject targetInteraction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        string interactionText = "";
        targetInteraction = null;

        if (Physics.Raycast(origin, direction, out raycastHit, m_distance))
        {
            targetInteraction = raycastHit.collider.gameObject.GetComponent<InteractionObject>();
            
        }
        if (targetInteraction != null)
        {
            interactionText = targetInteraction.GetInteractionText();
        }
        SetInteractableNameText(interactionText);

    }

    private void SetInteractableNameText(string newText)
    {
        if (interactableName != null)
        {
            interactableName.text = newText;
        }
    }

    public void TryInteract()
    {
        if (targetInteraction)
        {
            targetInteraction.Interact();
        }
    }
}
