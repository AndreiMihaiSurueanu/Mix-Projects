using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBear : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.LookRotation(
            Vector3.RotateTowards(transform.forward,
            target.transform.position - transform.position,
            Time.deltaTime, 0.0f));
    }
}
