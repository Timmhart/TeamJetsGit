using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueToMainMenu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Titelscherm 1");
    }
}