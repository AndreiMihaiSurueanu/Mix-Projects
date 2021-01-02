using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SongController : MonoBehaviour
{
    public static SongController instance { get; private set; }

   // public GameObject arrowPrefab;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Update is called once per frame
    public void keyPress(Rigidbody rigidbodyKey)
    {
        if (true)
        {
            GameObject arrowObject = GameObject.Find("arrowPrefab");
            Destroy(arrowObject);
            GameObject keyObject = GameObject.Find("key21 (1)");
            //arrowObject = Instantiate(arrowPrefab, rigidbodyKey.position + Vector3.up * 0.5f, Quaternion.identity);
         //   arrowObject = Instantiate(arrowPrefab, keyObject.GetComponent<Rigidbody>().position + Vector3.up * 0.5f, Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    public void testIn()
    {
        if (true)
        {
            print("test was called");
      //      GameObject arrowObject = GameObject.Find("arrowPrefab");
      //      Destroy(arrowObject);

        }
    }

}
