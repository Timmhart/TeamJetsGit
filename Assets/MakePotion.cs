using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePotion : MonoBehaviour
{
    public GameObject poppy;
    public GameObject redberry;
    public GameObject blood;
    public GameObject traan;

      void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Grace"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                poppy.SetActive(false);
                redberry.SetActive(false);
                blood.SetActive(false);
                traan.SetActive(false);
            }  
        }
        
    }

}
