using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public GameObject harry;

    public Vector2 playerStartPosition; // The starting position of the player in the original scene
    public string puzzleSceneName; // The name of the scene that contains the puzzle

  private Transform playerTransform;

    private void Start()
    {
        // Store the player's transform on Start
        playerTransform = GameObject.FindGameObjectWithTag("Harry").transform;
    }

    // Define a public property that returns the player's transform
    public Transform PlayerTransform
    {
        get { return playerTransform; }
    }
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

        // Subscribe to the sceneUnloaded event
        SceneManager.sceneUnloaded += OnSceneUnloaded;
    }

    private void OnDestroy()
    {
        // Unsubscribe from the sceneUnloaded event when the script is destroyed
        SceneManager.sceneUnloaded -= OnSceneUnloaded;
    }

    private void OnSceneUnloaded(Scene scene)
    {
        // Check if the unloaded scene is the puzzle scene
        if (scene.name == puzzleSceneName)
        {
            // Set the harry variable to the current instance of the player object
            harry = GameObject.FindWithTag("Player");
        }
    }

    public void StartPuzzle()
    {
        // Save the player's position before loading the puzzle scene
        playerStartPosition = harry.transform.position;

        // Load the puzzle scene
        SceneManager.LoadScene(puzzleSceneName);
    }

    public void EndPuzzle()
    {
        // Load the original scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // Set the player's position to the saved position
        harry.transform.position = playerStartPosition;
    }
}