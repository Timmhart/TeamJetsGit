using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SchaapPuzzel : MonoBehaviour
{

  public bool loadPuzzle = false;

  private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Harry")
        {
            loadPuzzle = false;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (loadPuzzle == true)
        {
            loadPuzzle = false; //we dont want to load the scene multiple times
            SceneManager.LoadScene("SchaapPuzzel");
        }   
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            loadPuzzle = true;
        }
    }
}
