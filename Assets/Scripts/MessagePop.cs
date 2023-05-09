using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MessagePop : MonoBehaviour
{
    public GameObject message;


    void Start()
    {
        message.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Grace" || other.gameObject.tag == "Harry")
        {
            message.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Grace" || other.gameObject.tag == "Harry")
        {
            message.SetActive(false);
        }
    }
}
