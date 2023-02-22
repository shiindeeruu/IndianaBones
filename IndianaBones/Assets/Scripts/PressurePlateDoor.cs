using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlateDoor : MonoBehaviour
{
    // public SlideDoor door;

    private int collectGoal = 2;
    private int collectState = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Key1"))
        {
            collectState++;
        }
        if(other.gameObject.CompareTag("Key2"))
        {
            collectState++;
        }
        if(collectState == collectGoal)
        {
            // door.open;
        }
    }
}
