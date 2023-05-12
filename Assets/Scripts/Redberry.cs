using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redberry : MonoBehaviour
{
    public GameObject redberryUI;
    // public bool berry = true;

    private void Awake()
    {
        Debug.Log("Redberries not active");
        redberryUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }

    void OnTriggerStay2D(Collider2D other)
    {
       
      if(other.gameObject.CompareTag("Harry"))
        {
                 if (Input.GetKeyDown(KeyCode.E)) 
        {
            redberryUI.SetActive(true);
            Destroy(gameObject);
        }
        }
    }
 
    // void Update()
    // {
    //     if (Input.GetKeyDown(KeyCode.E)) 
    //     {
    //         redberryUI.SetActive(true);
    //         Destroy(gameObject);
    //     }
    // }
}
