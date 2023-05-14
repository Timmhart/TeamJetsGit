using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadCutsceneKat2 : MonoBehaviour
{
    public bool MustLoadScene = false;
    public GameObject talkUI;
    [SerializeField] 
    private AudioSource audioSource;

    private void Start()
    {
        talkUI.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        talkUI.SetActive(true);
    }
 
    void OnTriggerStay2D(Collider2D other)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            MustLoadScene = true;
            audioSource.Play();
        }   
    }

    void OnTriggerExit2D(Collider2D other)
    {  
        talkUI.SetActive(false);
    }

    void Update()
    {
        if (MustLoadScene)
        {
            StartCoroutine(LoadSceneAfterDelay());
            MustLoadScene = false;
        }
    }

    IEnumerator LoadSceneAfterDelay()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("Cutscene 3");
    }
}