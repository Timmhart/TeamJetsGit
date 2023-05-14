using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTraan : MonoBehaviour
{
    public GameObject traanUI;
    public GameObject quest1;
    public GameObject quest2;
    public GameObject quest3;

    private void Start()
    {
        traanUI.SetActive(false);
        quest3.SetActive(false);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            traanUI.SetActive(true);
            Destroy(gameObject);
             quest1.SetActive(false);
              quest2.SetActive(false);
            quest3.SetActive(true);
        }   
    }
}
