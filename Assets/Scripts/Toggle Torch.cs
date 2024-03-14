using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NewBehaviourScript : MonoBehaviour
{
    private bool torchLit = true;
    public Mesh newMesh;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ToggleTorch()
    {
        MeshFilter meshFilter = GetComponent<MeshFilter>();
        Light light = GetComponentInChildren<Light>();
        if (torchLit)
        {

            Mesh temp = meshFilter.mesh;
            print(temp.name);
            meshFilter.mesh = newMesh;
            newMesh = temp;

            light.intensity = 0;
            torchLit = false;
        }
        else
        {
            Mesh temp = meshFilter.mesh;
            print(temp.name);
            meshFilter.mesh = newMesh;
            newMesh = temp;

            light.intensity = 1;
            torchLit = true;
        }
    }
}
