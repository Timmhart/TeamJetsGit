using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MakePotion : MonoBehaviour
{
    public GameObject poppy;
    public GameObject redberry;
    public GameObject blood;
    public GameObject traan;
    public float delay = 2f;

      void OnCollisionStay2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Grace"))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("Potion is gemaakt");
                poppy.SetActive(false);
                redberry.SetActive(false);
                blood.SetActive(false);
                traan.SetActive(false);
                Invoke("LoadCutscene", delay);
            }  
          }
    }

    public void LoadCutscene()
    {
        SceneManager.LoadScene("Cutscene 7");
    }
}
