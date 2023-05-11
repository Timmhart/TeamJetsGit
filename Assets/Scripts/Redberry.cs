using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redberry : MonoBehaviour
{
    public GameObject redberryUI;

    private void Start()
    {
        redberryUI.SetActive(false);

    }
//   private void OnTriggerEnter2D(Collider2D other)
//     {
//         if(other.gameObject.name == "Grace" && other.gameObject.name == "Harry")
//         {
        
//         }
//     }
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            redberryUI.SetActive(true);
            Destroy(gameObject);

        }   
    }
}
