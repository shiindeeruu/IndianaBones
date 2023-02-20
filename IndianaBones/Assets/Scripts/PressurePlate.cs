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
        if (!isOpen)
        {
            isOpen = true;
            door.transform.position += new Vector3(0, yDisplacement, 0); // z needs to change to z-position of the door
        }
    }
}
