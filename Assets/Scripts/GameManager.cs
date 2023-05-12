using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool candle1 = false;
    public bool candle2 = false;
    public CircleCollider2D circleCollider;
    public GameObject questTutorialGrace1;
    public GameObject questTutorialGrace2;

    public float loadSceneDelay = 1f;

    public Vector3 respawnPos;

    public ShootingHarry shootingHarry;
    public ShootingGrace1 shootingGrace;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else 
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        // instance = this;
        circleCollider.enabled = false;
        questTutorialGrace1.SetActive(true);
        questTutorialGrace2.SetActive(false);
    }

    public void EndGraceLevel()
    {
        if (candle1 && candle2)
        {
            Debug.Log("All candles lit! Loading next scene...");
            circleCollider.enabled = true;
            questTutorialGrace1.SetActive(false);
            questTutorialGrace2.SetActive(true);
            // Invoke("LoadNextScene", loadSceneDelay);
        }
    }

    // void LoadNextScene()
    // {
    //     // SceneManager.LoadScene("Harry");
    // }
}
