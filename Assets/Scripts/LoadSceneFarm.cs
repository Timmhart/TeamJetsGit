// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class LoadSceneFarm : MonoBehaviour
// {
    
//     void OnCollisionEnter2D(Collision2D other)
//     {
//         if(Input.GetKeyDown(KeyCode.E))
//         {
//             SceneManager.LoadScene("Cutscene 4");
//         }
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneFarm : MonoBehaviour
{
    public bool MustLoadScene = false;

    private void Start()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
            MustLoadScene = false;//we dont want to load the scene multible times    
    }
 
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            MustLoadScene = false;//we dont want to load the scene multible times
            SceneManager.LoadScene("Cutscene 4");
        }   
    }
 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) 
        {
            MustLoadScene = true;
        }
    }
}
