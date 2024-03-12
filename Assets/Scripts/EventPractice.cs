using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventPractice : MonoBehaviour
{
    public UnityEvent testEvent = new UnityEvent();

    // Start is called before the first frame update
    void Start()
    {
        testEvent.AddListener(TestListener);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            testEvent.Invoke();
        }
    }

    void TestListener()
    {
        print("listener Called");
    }
}
