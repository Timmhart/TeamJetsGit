using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneFarmBack : MonoBehaviour
{

  public bool loadFarmBack = false;

  private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Grace" && other.gameObject.name == "Harry")
        {
            loadFarmBack = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (loadFarmBack == true)
        {
            loadFarmBack = false; //we dont want to load the scene multiple times
            SceneManager.LoadScene("Farm");
        }   
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            loadFarmBack = true;
        }
    }
}