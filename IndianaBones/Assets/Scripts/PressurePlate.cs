using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public SlideDoor door;
    public int collectState = 0;

    private int collectGoal = 2;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key1"))
        {
            collectState += 1;
            Debug.Log(collectState);
        }
        if (other.gameObject.CompareTag("Key2"))
        {
            collectState += 1;
            Debug.Log(collectState);
        }
    }

    private void Update()
    {
        if (collectState == collectGoal)
        {
            door.open = true;
            Debug.Log("door is open\n");
        }
        if (collectState <= collectGoal)
        {
            door.open = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Key1"))
        {
            collectState -= 1;
            Debug.Log(collectState);
        }
        if (other.gameObject.CompareTag("Key2"))
        {
            collectState -= 1;
            Debug.Log(collectState);
        }
        if (collectState <= collectGoal)
        {
            door.open = false;
        }
    }
}
