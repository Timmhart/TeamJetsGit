using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLetterKat : MonoBehaviour
{
    public GameObject letterKat;

    private void Awake()
    {
        Debug.Log("JOOOOEEEEEOOEOEOOEOEOEOEOOEOEOEOE");
        letterKat.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Harry") || other.gameObject.CompareTag("Grace"))
        {
            letterKat.SetActive(true);
        }
    }

     private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Harry"))
        {
            letterKat.SetActive(false);
        }
    }
}
