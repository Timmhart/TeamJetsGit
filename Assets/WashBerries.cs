using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashBerries : MonoBehaviour
{
    public GameObject washedPopup;
    public GameObject washInfo;
    public GameObject quest2;
    public GameObject quest3;

    void Start()
    {
        // quest2.SetActive(true);
        washedPopup.SetActive(false);
    }
       void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Harry"))
        {
            if (Input.GetKeyDown(KeyCode.P)) 
            {
                Debug.Log("Gebeurd er nog wat?");
                washedPopup.SetActive(true);
                quest2.SetActive(false);
                quest3.SetActive(true);
                washInfo.SetActive(false);
            }
        }
    }
       void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Harry"))
        {
            Debug.Log("Gebeurd er nog wat?");
            washedPopup.SetActive(false);
        }
    }
}

