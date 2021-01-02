using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour
{
    public string logMessage= "The amount of calories you just consumed is:";
    public int calories = 999;
    // Start is called before the first frame update
 public   int itGotClicked()
    {
        Debug.Log(logMessage + calories);
        return calories;
    }

}
