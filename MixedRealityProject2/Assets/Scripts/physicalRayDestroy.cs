using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class physicalRayDestroy : MonoBehaviour
{


    //[SerializeField]
    //private Button dismissButton;

    [SerializeField]
    private GameObject welcomePanel;


    int totalKCal = 0;
    public AudioClip eatingSound;
    // Start is called before the first frame update
    void Start()
    {
        welcomePanel = GameObject.Find("Panel").GetComponent<GameObject>();

        Debug.Log("Tap on food items to start eating!");
    }


    //void Awake() 
    //{
    //    dismissButton.onClick.AddListener(Dismiss);
    //}

    public void Dismiss() => welcomePanel.SetActive(false);


    // Update is called once per frame
    void Update()
    {



            if (Input.GetMouseButtonDown(0))
        //    if (Input.GetTouch(0).position != null)
        {
           // Debug.Log("touch detected");

        //    Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.GetTouch(0).position);

            Ray ray = GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);


            RaycastHit s_Hits;
            if (Physics.Raycast(ray, out s_Hits))
            {
                ObjectController e = s_Hits.collider.GetComponent<ObjectController>();

                Vector3 colliderPointion = s_Hits.collider.transform.position;
                PlaySound(eatingSound, colliderPointion);

                int foodKCal = e.itGotClicked();
                totalKCal = totalKCal + foodKCal;
                Debug.Log("You have eaten " + totalKCal + " calories in total");




                Destroy(s_Hits.collider.gameObject);

                if(totalKCal>4000)
                {
                    GameIsOver();
                  //  Debug.Log("You are now fat. GAME OVER");
                }
            }
        }

        /*
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.Log("Raycasting Detected: " + hit.collider.tag);
            if (hit.collider.tag == "DroneStoreItem")
            {
                GameObject droneStoreItem = hit.collider.gameObject;


            }
        }

            */
    }

    private void GameIsOver()
    {
        for(int i=1;i<6;i++)
        {
            Debug.Log("You are now fat. GAME OVER");
           
        }
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(5);
        quitGame();
    }


    public void PlaySound(AudioClip clip, Vector3 colliderPointion)
    {
        //  audioSource.PlayOneShot(clip);
        AudioSource.PlayClipAtPoint(clip, colliderPointion);
    }



    private void quitGame()
    {
        Application.Quit();
        Debug.Log("please quit the game manually");
        if (Application.platform == RuntimePlatform.Android)
        {
            AndroidJavaObject activity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
            activity.Call<bool>("moveTaskToBack", true);
        }
        else
        {
            Application.Quit();
        }
    }



}
