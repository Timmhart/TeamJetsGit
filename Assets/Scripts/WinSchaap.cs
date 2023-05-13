using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinSchaap : MonoBehaviour
{
    private int pointsToWin;
    private int currentPoints;
    public GameObject myKeys;
    public float timeToLoadNextScene = 1.5f; // Set the time to wait before loading the next scene here

    // Start is called before the first frame update
    void Start()
    {
        pointsToWin = myKeys.transform.childCount;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentPoints >= pointsToWin)
        {
            transform.GetChild(0).gameObject.SetActive(true);
            Invoke("LoadNextScene", timeToLoadNextScene); // Call the LoadNextScene method after the specified time
        }
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene("Farm 2");

    }

    public void AddPoints()
    {
        currentPoints++;
    }
}