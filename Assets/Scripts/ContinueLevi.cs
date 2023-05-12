using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueLevi : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("Bad Choice");
    }
}
