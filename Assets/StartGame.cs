using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
   public string levelName;

   public void StartLevel()
   {
        Debug.Log("Next scene is coming");
        SceneManager.LoadScene(levelName);
   }
}
