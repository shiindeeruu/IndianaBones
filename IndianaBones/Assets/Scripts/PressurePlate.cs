using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public SlideDoor door;

    private int collectGoal = 2;
    private int collectState = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Key1"))
        {
            collectState++;
        }
        if (other.gameObject.CompareTag("Key2"))
        {
            collectState++;
        }
        if (collectState == collectGoal)
        {
            door.open = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Key1"))
        {
            collectState--;
        }
        if (other.gameObject.CompareTag("Key2"))
        {
            collectState--;
        }
        if (collectState < collectGoal)
        {
            door.open = false;
        }
    }
}
