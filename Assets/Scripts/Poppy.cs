using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poppy : MonoBehaviour
{
    public GameObject poppyUI;
    public GameObject quest2;
    public GameObject quest3;
     [SerializeField] 
    private AudioSource audioSource;

    private void Start()
    {
        poppyUI.SetActive(false);
        quest3.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            poppyUI.SetActive(true);
            Destroy(gameObject);
            quest2.SetActive(false);
            quest3.SetActive(true);
            audioSource.enabled = true;
            audioSource.Play();
        }   
    }
}
