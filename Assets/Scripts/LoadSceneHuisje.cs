using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneHuisje : MonoBehaviour
{

  public bool loadHuis = false;

  private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Grace" && other.gameObject.name == "Harry")
        {
            loadHuis = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (loadHuis == true)
        {
            loadHuis = false; //we dont want to load the scene multiple times
            SceneManager.LoadScene("FarmHuis");
        }   
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            loadHuis = true;
        }
    }
}