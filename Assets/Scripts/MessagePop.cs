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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Grace" || other.gameObject.tag == "Harry")
        {
            message.SetActive(true);
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "Grace" || other.gameObject.tag == "Harry")
        {
            message.SetActive(false);
        }
    }
}
