using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveChair : MonoBehaviour
{
    public bool chairMoved = false;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void moveChair()
    {
        if (chairMoved)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + .5f);
            chairMoved = false;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - .5f);
            chairMoved = true;
        }
    }
}
