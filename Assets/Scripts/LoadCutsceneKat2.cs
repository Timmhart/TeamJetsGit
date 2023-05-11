using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCutsceneKat2 : MonoBehaviour
{
    public bool MustLoadScene = false;
    public GameObject talkUI;

    private void Start()
    {
        talkUI.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            MustLoadScene = false;//we dont want to load the scene multible times    
            talkUI.SetActive(true);
    }
 
    void OnTriggerStay2D(Collider2D other)
    {
        if (MustLoadScene == true)
        {
            MustLoadScene = false;//we dont want to load the scene multible times
            SceneManager.LoadScene("Cutscene 3");
        }   
    }

     void OnTriggerExit2D(Collider2D other)
    {  
            talkUI.SetActive(false);
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            MustLoadScene = true;
        }
    }
}
