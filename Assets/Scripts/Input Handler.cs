using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    PlayerCamera playerCamera;
    PlayerMovement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        playerCamera = GetComponent<PlayerCamera>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
        HandlePlayerMovement();
    }

    void HandleCameraInput()
    {
        playerCamera.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        playerCamera.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
    }
    void HandlePlayerMovement()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");

        playerMovement.AddMoveInput(forwardInput, rightInput);
    }
}
