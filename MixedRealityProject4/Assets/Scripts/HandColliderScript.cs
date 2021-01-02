using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandColliderScript : MonoBehaviour
{
    public GameObject spherePrefab;
    public GameObject[] fingers;
    public GameObject[] spheres;

    private bool[] fingerFound;

    // Start is called before the first frame update
    void Start()
    {
        fingers = new GameObject[5];
        spheres = new GameObject[5];

        fingerFound = new bool[10];
        for(int i=0; i<fingerFound.Length; i++)
        {
            fingerFound[i] = false;
        }
        
        for (int i=0; i<spheres.Length; i++)
        {
            spheres[i] = Instantiate(spherePrefab, new Vector3(0, 0, 0), Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        fingers[0] = transform.GetChild(0).transform.GetChild(0).transform.GetChild(1).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).gameObject;
        fingers[1] = transform.GetChild(0).transform.GetChild(0).transform.GetChild(2).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).gameObject;
        fingers[2] = transform.GetChild(0).transform.GetChild(0).transform.GetChild(3).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).gameObject;
        fingers[3] = transform.GetChild(0).transform.GetChild(0).transform.GetChild(4).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).gameObject;
        fingers[4] = transform.GetChild(0).transform.GetChild(0).transform.GetChild(5).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).transform.GetChild(0).gameObject;

        for (int i = 0; i < spheres.Length; i++)
        {
            spheres[i].transform.position = fingers[i].transform.position;
        }
        /*for(int i=0; i<spheres.Length; i++)
        {
            spheres[i] = Instantiate(spherePrefab, fingers[i].transform);//, Quaternion.identity
        }*/
    }
}
