using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBushRed : MonoBehaviour
{
//   public bool bush = true;
//   public GameObject redberry;

//   void Start()
//   {
//       redberry.SetActive(false);
//   }

  private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(gameObject);
        }
    }
    // void OnTriggerStay2D(Collider2D other)
    // {
    //     // if (bush == false)
    //     // {
    //             if (Input.GetKeyDown(KeyCode.E)) 
    //             {
    //                 Debug.Log("bush is gone");
    //                 // bush = false;
    //                 redberry.SetActive(true);
    //                 // bush = true; //we dont want to load the scene multiple times
                    
    //             }
    //         }   
    }

