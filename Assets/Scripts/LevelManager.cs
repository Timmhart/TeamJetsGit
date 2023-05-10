using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public GameObject harry;


    public Vector2 playerStartPosition; // The starting position of the player in the original scene
    public string puzzleSceneName; // The name of the scene that contains the puzzle

    private void Awake()
    {
        
        // Ensure that there is only one instance of the LevelManager in the scene
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StartPuzzle()
    {
         Debug.Log("harry");
        // Save the player's position before loading the puzzle scene
        playerStartPosition = harry.transform.position;

        // Load the puzzle scene
        SceneManager.LoadScene(puzzleSceneName);
    }

    public void EndPuzzle()
    {
        Debug.Log("harry");
        // Load the original scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Set the player's position to the saved position
        harry.transform.position = playerStartPosition;
        
    }
}