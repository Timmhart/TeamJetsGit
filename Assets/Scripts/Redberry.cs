using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redberry : MonoBehaviour
{
    public GameObject redberryUI;
    public GameObject quest1;
    public GameObject quest2;

    private void Awake()
    {
        Debug.Log("Redberries not active");
        redberryUI.SetActive(false);
        quest2.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {  
      if(other.gameObject.CompareTag("Harry"))
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                redberryUI.SetActive(true);
                Destroy(gameObject);
                quest1.SetActive(false);
                quest2.SetActive(true);
            }
        }
    }
}
