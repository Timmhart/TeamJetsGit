using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupTraan : MonoBehaviour
{
    public GameObject traanUI;

    private void Start()
    {
        traanUI.SetActive(false);
    }

    void OnCollisionStay2D(Collision2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            traanUI.SetActive(true);
            Destroy(gameObject);
        }   
    }
}
