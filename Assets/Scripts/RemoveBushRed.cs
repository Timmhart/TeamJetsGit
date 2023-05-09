using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBushRed : MonoBehaviour
{
  private bool bush = true;
  public GameObject redberry;

  void Start()
  {
      redberry.SetActive(false);
  }

  private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Grace" && other.gameObject.name == "Harry")
        {
            bush = true;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (bush == false)
        {
            bush = true; //we dont want to load the scene multiple times
            Destroy(gameObject);
        }   
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            Debug.Log("bush is gone");
            bush = false;
            redberry.SetActive(true);
        }
    }
}
