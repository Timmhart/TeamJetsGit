using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartKnop : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Grace");
    }
}
 