using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redberry : MonoBehaviour
{
    public GameObject redberryUI;
    public bool berry = true;

    private void Awake()
    {
        Debug.Log("Redberries not active");
        redberryUI.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.name == "Grace" && other.gameObject.name == "Harry")
        {
            berry = true;
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (berry == false)
        {
            berry = true; //we dont want to load the scene multiple times
            // Destroy(gameObject);
        }   
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            redberryUI.SetActive(true);
            Destroy(gameObject);
        }
    }
}
