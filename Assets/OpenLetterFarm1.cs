using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLetterFarm1 : MonoBehaviour
{
    public GameObject letterFarm1;

    private void Awake()
    {
        Debug.Log("JOOOOEEEEEOOEOEOOEOEOEOEOOEOEOEOE");
        letterFarm1.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Harry") || other.gameObject.CompareTag("Grace"))
        {
            letterFarm1.SetActive(true);
        }
    }

     private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Harry") || other.gameObject.CompareTag("Grace"))
        {
            letterFarm1.SetActive(false);
        }
    }
}
