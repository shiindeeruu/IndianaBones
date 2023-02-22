using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tripwire : MonoBehaviour
{
    public GameObject leftSpikes;
    public GameObject rightSpikes;
    public float xLeft;
    public float xRight;
    public float y;
    public float z;
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
        leftSpikes.transform.position = new Vector3(xLeft, y, z);
        rightSpikes.transform.position = new Vector3(xRight, y, z);
    }

    private void OnTriggerExit(Collider other)
    {
        leftSpikes.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
        rightSpikes.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }
}
