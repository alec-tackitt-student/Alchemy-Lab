using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputHandler : MonoBehaviour
{

    PlayerCamera playerCamera;
    PlayerMovement playerMovement;
    PlayerInteraction playerInteraction;
    public static KeyCode interactKey = KeyCode.F;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = GetComponent<PlayerCamera>();
        playerMovement = GetComponent<PlayerMovement>();
        playerInteraction = GetComponent<PlayerInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
        HandlePlayerMovement();
        HandleInteractionInput();
    }

    void HandleCameraInput()
    {
        playerCamera.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        playerCamera.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }
    void HandlePlayerMovement()
    {
        float forwardInput = Input.GetAxisRaw("Vertical");
        float rightInput = Input.GetAxisRaw("Horizontal");

        playerMovement.AddMoveInput(forwardInput, rightInput);
    }

    void HandleInteractionInput()
    {
        if (Input.GetKeyDown(interactKey))
        {
            playerInteraction.TryInteract();
        }

        if(Input.GetKeyDown(KeyCode.Escape)) 
        {
            GameManager.LoadScene("Main Screen");
        }
    }
}
