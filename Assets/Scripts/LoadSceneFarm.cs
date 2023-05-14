// // using UnityEngine;
// // using UnityEngine.SceneManagement;

// // public class LoadSceneFarm : MonoBehaviour
// // {
    
// //     void OnCollisionEnter2D(Collision2D other)
// //     {
// //         if(Input.GetKeyDown(KeyCode.E))
// //         {
// //             SceneManager.LoadScene("Cutscene 4");
// //         }
// //     }
// // }

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.SceneManagement;

// public class LoadSceneFarm : MonoBehaviour
// {
//     public bool MustLoadScene = false;
//     [SerializeField] 
//     private AudioSource audioSource;

//     private void Start()
//     {
//     }

//     void OnTriggerEnter2D(Collider2D other)
//     {
//             MustLoadScene = false;//we dont want to load the scene multible times    
//     }
 
//     void OnTriggerStay2D(Collider2D other)
//     {
//         if (Input.GetKeyDown(KeyCode.E))
//         {
//             MustLoadScene = false;//we dont want to load the scene multible times
//             SceneManager.LoadScene("Cutscene 4");
//         }   
//     }
 
//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.E)) 
//         {
//             MustLoadScene = true;
//             audioSource.Play();
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
    [SerializeField] 
    private AudioSource audioSource;

    void OnTriggerEnter2D(Collider2D other)
    {
        MustLoadScene = false;
    }
 
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            MustLoadScene = true;
            audioSource.Play();
        }   
    }
 
    void Update()
    {
        if (MustLoadScene)
        {
            StartCoroutine(LoadSceneAfterDelay());
            MustLoadScene = false;
        }
    }

    IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Cutscene 4");
    }
}






