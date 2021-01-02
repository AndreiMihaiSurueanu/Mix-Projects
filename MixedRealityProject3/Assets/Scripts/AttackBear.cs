using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackBear : MonoBehaviour
{
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z), Time.deltaTime*0.5f);
    }
}
