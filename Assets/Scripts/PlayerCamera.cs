using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    private float xAxis;
    private float yAxis;
    public static float xAxisTurnRate = Settings.currentSensitivity;
    public static float yAxisTurnRate = Settings.currentSensitivity;
    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void LateUpdate()
    {  
        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;

        xAxisTurnRate = Settings.currentSensitivity;
        yAxisTurnRate = Settings.currentSensitivity;

    }

    public void AddXAxisInput(float xAxisInput)
    {
        xAxis -= xAxisInput * xAxisTurnRate;
        xAxis = Mathf.Clamp(xAxis, -90f, 90f);
    }
    public void AddYAxisInput(float yAxisInput)
    {
        yAxis += yAxisInput * yAxisTurnRate;
    }
}
