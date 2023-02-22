using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideDoor : MonoBehaviour
{
    // Start is called before the first frame update
    public bool open = false;

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
        if (open)
        {
            transform.position = openedPosition;
        } else
        {
            transform.position = closedPosition;
        }
    }
}
