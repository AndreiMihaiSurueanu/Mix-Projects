using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour
{
    public GameObject targetForward;
    public GameObject targetBackward;
    public GameObject targetRight;
    public GameObject targetLeft;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.Get(OVRInput.Button.PrimaryThumbstickUp) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickUp))
        {
            transform.position = Vector3.MoveTowards(transform.position, 
                new Vector3(targetForward.transform.position.x, transform.position.y, targetForward.transform.position.z), Time.deltaTime);
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickDown) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickDown))
        {
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(targetBackward.transform.position.x, transform.position.y, targetBackward.transform.position.z), Time.deltaTime);
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickRight) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickRight))
        {
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(targetRight.transform.position.x, transform.position.y, targetRight.transform.position.z), Time.deltaTime);
        }
        if (OVRInput.Get(OVRInput.Button.PrimaryThumbstickLeft) || OVRInput.Get(OVRInput.Button.SecondaryThumbstickLeft))
        {
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(targetLeft.transform.position.x, transform.position.y, targetLeft.transform.position.z), Time.deltaTime);
        }
    }
}
