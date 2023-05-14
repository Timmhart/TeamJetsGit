using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneGrot : MonoBehaviour
{

  public bool loadGrot = false;

  private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Grace" && other.gameObject.name == "Harry")
        {
            loadGrot = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (loadGrot == true)
        {
            loadGrot = false; //we dont want to load the scene multiple times
            SceneManager.LoadScene("Cutscene 6");
        }   
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            loadGrot = true;
        }
    }
}