using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject door;
    public float yDisplacement;

    private bool isOpen = false;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Bone" || other.tag == "Skull" || other.tag == "Player")
        {
            // open door
            float distance = Vector3.Distance(transform.position, other.transform.position);
            Debug.Log("Distance: " + distance);

            if (distance < 0.05f)
            {
                Rigidbody obj = other.GetComponent<Rigidbody>();
                if (obj != null)
                {
                    obj.isKinematic = true;
                }
                MeshRenderer renderer = GetComponentInChildren<MeshRenderer>();
                if (renderer != null)
                {
                    renderer.material.color = Color.blue;
                }

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isOpen && (other.tag == "Key1" || other.tag == "Key2"))
        {
            isOpen = true;
            door.transform.position += new Vector3(0, yDisplacement, 0); // z needs to change to z-position of the door
        }

        /*
         * if both pressure plates have an object on it
         *      if the objects on the pressure plate are the key objects
         *          open the door
         */
    }

    private void OnTriggerExit(Collider other)
    {
        if (isOpen && (other.tag == "Key1" || other.tag == "Key2"))
        {
            isOpen = false;
            door.transform.position += new Vector3(0, 1.416f, 0); // z needs to change to z-position of the door
        }
    }
}
