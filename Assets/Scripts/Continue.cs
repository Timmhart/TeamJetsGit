using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    // public float timeToLoadNextScene = 56f;
    // void Start()
    // {
    //     gameObject.SetActive(false);
    // }

    // void Update()
    // {
    //     Invoke("LoadScene", timeToLoadNextScene);
    // }
    public void LoadScene()
    {
        SceneManager.LoadScene("Grace");
    }
}
