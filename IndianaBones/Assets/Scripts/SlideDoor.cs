using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public bool open = false;
    public PressurePlate plate1;
    public PressurePlate plate2;

    private Vector3 closedPosition;
    private Vector3 openedPosition;

    void Start()
    {
        closedPosition = transform.position;
        openedPosition = new Vector3(closedPosition.x, closedPosition.y + 3, closedPosition.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (plate1.collectState + plate2.collectState == 2)
        {
            open = true;
            Debug.Log("door is open\n");
        }
        if (plate1.collectState + plate2.collectState < 2)
        {
            open = false;
        }

        if (open)
        {
            transform.position = openedPosition;
        } else
        {
            transform.position = closedPosition;
        }
    }
}
