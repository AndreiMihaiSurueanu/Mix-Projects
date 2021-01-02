using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fight : MonoBehaviour
{
    public GameObject myLife;
    public GameObject bearLife;
    public GameObject deadBear;
    public GameObject thisBear;
    public GameObject winCanvas;
    public GameObject loseCanvas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(myLife.GetComponent<Scrollbar>().size==0)
        {
            myLife.SetActive(false);
            loseCanvas.SetActive(true);
        }
        if (bearLife.GetComponent<Scrollbar>().size == 0)
        {
            bearLife.SetActive(false);
            winCanvas.SetActive(true);
            deadBear.SetActive(true);
            deadBear.transform.position = transform.position;
            thisBear.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="me")
        {
            myLife.GetComponent<Scrollbar>().size -= 0.25f;
        }
        if(other.gameObject.tag == "sword")
        {
            FindObjectOfType<AudioManager>().Play("Cut");
            bearLife.GetComponent<Scrollbar>().size -= 0.1f;
        }
    }
}
