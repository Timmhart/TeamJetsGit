using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashBerries : MonoBehaviour
{
    public GameObject washedPopup;

    void Start()
    {
        washedPopup.SetActive(false);
    }
       void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Harry"))
        {
            if (Input.GetKeyDown(KeyCode.E)) 
            {
                washedPopup.SetActive(true);
            }
        }
    }
}

