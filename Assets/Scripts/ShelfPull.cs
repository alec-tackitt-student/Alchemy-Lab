using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShelfPull : MonoBehaviour
{
    
    public bool hasBeenPulled = false;
    public static int itemsPulled = 0;
    // Start is called before the first frame update
    void Start()
    {
        itemsPulled = 0; 
    }
    public void shelfPull()
    {
        itemsPulled++;
        InteractionObject interactionObject = GetComponent<InteractionObject>();
        if (!hasBeenPulled){
        Rigidbody body = GetComponent<Rigidbody>();
        Vector3 vector3 = transform.position;
        vector3.x -= 1;

        body.AddExplosionForce(150f, vector3, 10f);

        hasBeenPulled = true;
       } 
    }
}
