using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tableclear : MonoBehaviour
{

    public bool isCleared = false;
    public static int clearedItems = 0;
    public Transform shelfLocation;
    // Start is called before the first frame update
    void Start()
    {
        clearedItems = 0;
    }

    public void Clear()
    {
        if(!isCleared)
        {
            clearedItems++;
            transform.position = shelfLocation.position;
            isCleared = true;
        }
    }
    
}
