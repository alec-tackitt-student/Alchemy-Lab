using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Settings : MonoBehaviour
{
    public Slider sensitivitySlider;
    public static float currentSensitivity = 360f;
    public InputField interactField;
    public Text interactText;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    public void SetSensitivity()
    {
        currentSensitivity = sensitivitySlider.value;
        
    }
    
}
