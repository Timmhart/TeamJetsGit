using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenLetterFarm2 : MonoBehaviour
{
    public GameObject letterFarm2;

    private void Awake()
    {
        Debug.Log("JOOOOEEEEEOOEOEOOEOEOEOEOOEOEOEOE");
        letterFarm2.SetActive(false);
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Harry") || other.gameObject.CompareTag("Grace"))
        {
            letterFarm2.SetActive(true);
        }
    }

     private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Harry") || other.gameObject.CompareTag("Grace"))
        {
            letterFarm2.SetActive(false);
        }
    }
}
