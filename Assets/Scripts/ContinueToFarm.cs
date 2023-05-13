using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueToFarm : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Farm");
    }
}
