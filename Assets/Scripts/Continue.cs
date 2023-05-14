using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Continue : MonoBehaviour
{
    public float delayTime = 55.0f; // Wait 55 seconds before showing the button
    public Button button;

    private bool buttonShown = false;

    void Start()
    {
        // Disable the button game object on start
        button.gameObject.SetActive(false);
    }

    void Update()
    {
        delayTime -= Time.deltaTime;

        if (delayTime <= 0 && !buttonShown)
        {
            buttonShown = true;
            // Enable the button game object
            button.gameObject.SetActive(true);
        }
    }

    public void LoadGraceScene()
    {
        SceneManager.LoadScene("Grace");
    }
}