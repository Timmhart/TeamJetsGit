using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLetterBos : MonoBehaviour
{
    public GameObject letterBos;

    private void Awake()
    {
        Debug.Log("JOOOOEEEEEOOEOEOOEOEOEOEOOEOEOEOE");
        letterBos.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Harry") || other.gameObject.CompareTag("Grace"))
        {
            letterBos.SetActive(true);
        }
    }

     private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Harry") || other.gameObject.CompareTag("Grace"))
        {
            letterBos.SetActive(false);
        }
    }
}
