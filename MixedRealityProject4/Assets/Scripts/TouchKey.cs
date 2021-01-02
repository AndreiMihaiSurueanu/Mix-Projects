using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchKey : MonoBehaviour
{
    int note = 0;
    GameObject arrowObject;


    public GameObject arrowPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "key")
        {

            //  SongController.instance.
           //TestIn();
            col.gameObject.transform.GetChild(0).gameObject.transform.localPosition = new Vector3(0, 0, -1f);
            col.gameObject.transform.GetComponent<AudioSource>().Play();
            //songController.instance.keyPress(col.gameObject.GetComponent<Rigidbody>());
            Destroy(GameObject.FindWithTag("arrow"));
            keyPress();
            //songController.instance.keyPress(col.gameObject.transform.GetChild(0).gameObject.GetComponent<Rigidbody>());
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.gameObject.tag == "key")
        {
            col.gameObject.transform.GetChild(0).gameObject.transform.localPosition = new Vector3(0, 0, 0);
        }
    }

    public void keyPress()
    {
        if (true)
        {

          //  while (GameObject.FindWithTag("arrow") != null) {
              //  arrowObject = GameObject.FindWithTag("arrow");
          //  Destroy(GameObject.FindWithTag("arrow"));

           // }
   
            //arrowObject = Instantiate(arrowPrefab, rigidbodyKey.position + Vector3.up * 0.5f, Quaternion.identity);
            //arrowObject = Instantiate(arrowPrefab, keyObject.GetComponent<Rigidbody>().position + Vector3.up * 0.8f, Quaternion.identity);

            switch (note) {

                case 0:
                    //1st line
                    //I
                    //G note
                    Instantiate(arrowPrefab, new Vector3(0.05f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 1:
                    //Love
                    //E note
                    Instantiate(arrowPrefab, new Vector3(-0.023f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 2:
                    //you
                    //G note
                    // arrowObject = Instantiate(arrowPrefab, new Vector3(0.037f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    Instantiate(arrowPrefab, new Vector3(0.05f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 3:
                    //you
                    //G note
                    Instantiate(arrowPrefab, new Vector3(0.05f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 4:
                    //Love
                    //E note
                    Instantiate(arrowPrefab, new Vector3(-0.023f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 5:
                    //me
                    //G note
                    Instantiate(arrowPrefab, new Vector3(0.05f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 6:
                    //2nd line
                    //we're
                    //A note
                    Instantiate(arrowPrefab, new Vector3(0.08f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 7:
                    //a
                    //G note
                    Instantiate(arrowPrefab, new Vector3(0.05f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 8:
                    //hap
                    //F note
                    Instantiate(arrowPrefab, new Vector3(0.01f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 9:
                    //py
                    //E note
                    Instantiate(arrowPrefab, new Vector3(-0.023f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 10:
                    //fa
                    //D note
                    Instantiate(arrowPrefab, new Vector3(-0.058f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 11:
                    //mi
                    //E note
                    Instantiate(arrowPrefab, new Vector3(-0.023f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 12:
                    //ly
                    //F note
                    Instantiate(arrowPrefab, new Vector3(0.01f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 13:
                    //3rd line
                    //with
                    //E note
                    Instantiate(arrowPrefab, new Vector3(-0.023f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 14:
                    //a
                    //F note
                    Instantiate(arrowPrefab, new Vector3(0.01f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 15:
                    //great
                    //G note
                    Instantiate(arrowPrefab, new Vector3(0.05f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 16:
                    //big
                    //C note
                    Instantiate(arrowPrefab, new Vector3(-0.088f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 17:
                    //hug
                    //C note
                    Instantiate(arrowPrefab, new Vector3(-0.088f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 18:
                    //and
                    //C note
                    Instantiate(arrowPrefab, new Vector3(-0.088f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 19:
                    //a
                    //C note
                    Instantiate(arrowPrefab, new Vector3(-0.088f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 20:
                    //kiss
                    //C note
                    Instantiate(arrowPrefab, new Vector3(-0.088f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 21:
                    //from
                    //D note
                    Instantiate(arrowPrefab, new Vector3(-0.058f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 22:
                    //me
                    //E note
                    Instantiate(arrowPrefab, new Vector3(-0.023f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 23:
                    //to
                    //F note
                    Instantiate(arrowPrefab, new Vector3(0.01f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 24:
                    //you
                    //G note
                    Instantiate(arrowPrefab, new Vector3(0.05f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 25:
                    //4th
                    //wont
                    //G note
                    Instantiate(arrowPrefab, new Vector3(0.05f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 26:
                    //you
                    //D note
                    Instantiate(arrowPrefab, new Vector3(-0.058f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 27:
                    //say
                    //D note
                    Instantiate(arrowPrefab, new Vector3(-0.058f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 28:
                    //you
                    //F note
                    Instantiate(arrowPrefab, new Vector3(0.01f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 29:
                    //love
                    //E note
                    Instantiate(arrowPrefab, new Vector3(-0.023f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 30:
                    //me
                    //D note
                    Instantiate(arrowPrefab, new Vector3(-0.058f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    break;

                case 31:
                    //kiss
                    //C note
                    Instantiate(arrowPrefab, new Vector3(-0.088f, 1.264f, 0.143f), Quaternion.Euler(-90, 0, 0));
                    note = -1;
                    break;

                default:
                    break;
        }

            note = note + 1;  

        }
    }

    public void testIn()
    {
        if (true)
        {
            print("test was called");
                  GameObject arrowObject = GameObject.Find("arrowPrefab");
                 Destroy(arrowObject);

        }
    }

}
