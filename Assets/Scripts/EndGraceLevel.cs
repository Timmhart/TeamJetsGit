using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGraceLevel : MonoBehaviour
{
    public bool MustLoadScene = false;

    void OnTriggerEnter2D(Collider2D other)
    {
            MustLoadScene = false;//we dont want to load the scene multible times    
    }
 
    void OnTriggerStay2D(Collider2D other)
    {
        if (MustLoadScene == true)
        {
            MustLoadScene = false;//we dont want to load the scene multible times
            SceneManager.LoadScene("Harry");
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
