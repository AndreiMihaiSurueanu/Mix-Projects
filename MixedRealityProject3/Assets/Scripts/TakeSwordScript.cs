using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeSwordScript : MonoBehaviour
{
    public GameObject hint;
    public GameObject oldSword;
    public GameObject newSword;
    public GameObject touchController;
    public GameObject oldCage;
    public GameObject newCage;
    public GameObject bearCage;
    public GameObject bearAttack;
    public GameObject lives;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(hint.activeSelf && OVRInput.Get(OVRInput.Button.PrimaryHandTrigger) ||
            hint.activeSelf && OVRInput.Get(OVRInput.Button.SecondaryHandTrigger))
        {
            newSword.SetActive(true);
            hint.SetActive(false);
            oldSword.SetActive(false);
            oldCage.SetActive(false);
            newCage.SetActive(true);
            bearCage.SetActive(false);
            bearAttack.SetActive(true);
            lives.SetActive(true);
            touchController.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "sword")
        {
            hint.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "sword")
        {
            hint.SetActive(false);
        }
    }
}
