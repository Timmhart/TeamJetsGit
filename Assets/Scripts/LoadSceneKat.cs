using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneKat : MonoBehaviour
{

  public bool loadKat = false;

  private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Grace" && other.gameObject.name == "Harry")
        {
            loadKat = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (loadKat == true)
        {
            loadKat = false; //we dont want to load the scene multiple times
            SceneManager.LoadScene("Kat");
        }   
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            loadKat = true;
        }
    }
}
