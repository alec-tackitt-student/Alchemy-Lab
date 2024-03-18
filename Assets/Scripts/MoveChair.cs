using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MoveChair : MonoBehaviour
{
    private bool chairMoved = false;
    public bool chairIn;
    public static int chairsIn = 5;
    public static bool firstObjectiveDone = false;
    // Start is called before the first frame update
    void Start()
    {
        chairsIn = 5;
        firstObjectiveDone = false;
    }
    public void moveChair()
    {
        if (chairMoved)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + .5f);
            chairMoved = false;

            if(chairIn)
            {
                chairIn = false;
                chairsIn--;
            }
            else
            {
                chairIn= true;
                chairsIn++;
            }
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - .5f);
            chairMoved = true;

            if (chairIn)
            {
                chairIn = false;
                chairsIn--;
            }
            else
            {
                chairIn = true;
                chairsIn++;
            }
        }
    }
}
