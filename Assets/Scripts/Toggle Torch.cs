using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ToggleTorch : MonoBehaviour
{
    private bool torchLit = true;
    public Mesh newMesh;
    public static int torchesOff = 0;
    // Start is called before the first frame update
    void Start()
    {
        torchesOff = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void toggleTorch()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Light light = GetComponentInChildren<Light>();
        if (torchLit)
        {
            Mesh temp = meshFilter.mesh;
            
            meshFilter.mesh = newMesh;
            newMesh = temp;

            light.intensity = 0;
            torchLit = false;
            torchesOff++;
        }

        else
        {
            Mesh temp = meshFilter.mesh;
           
            meshFilter.mesh = newMesh;
            newMesh = temp;

            light.intensity = 1;
            torchLit = true;
            torchesOff--;
        }
    }
}
