using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShelfPull : MonoBehaviour
{

    private bool hasBeenPulled = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void shelfPull()
    {
        if (!hasBeenPulled){
        Rigidbody body = GetComponent<Rigidbody>();
        Vector3 vector3 = transform.position;
        vector3.x -= 1;

        body.AddExplosionForce(150f, vector3, 10f);

        hasBeenPulled = true;
        }
        
    }
}
