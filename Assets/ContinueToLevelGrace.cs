using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueToLevelGrace: MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Grace");
    }
}