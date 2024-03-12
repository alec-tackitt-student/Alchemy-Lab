using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    private float xAxis;
    private float yAxis;
    public float xAxisTurnRate = 360f;
    public float yAxisTurnRate = 360f;
    // Start is called before the first frame update
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private void LateUpdate()
    {  
        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;
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
