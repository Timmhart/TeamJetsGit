using UnityEngine;

public class Candle : MonoBehaviour
{
   
    public GameObject prefab; 
    [SerializeField] 
    private AudioSource audioSource;
    
    void Start() 
    {
    }

   private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Bullet"))
    {
        Debug.Log("Bullet collided with candle");
        Instantiate(prefab, transform.position, transform.rotation);
        Destroy(gameObject);
        GameManager.instance.EndGraceLevel();

        GameManager gameManager = FindObjectOfType<GameManager>();

        // Check which candle has been collided with and set the corresponding boolean value in the GameManager
            if (gameObject.name == "Candle1")
            {
                gameManager.candle1 = true;
                audioSource.enabled = true;
                audioSource.Play();
            }
            else if (gameObject.name == "Candle2")
            {
                gameManager.candle2 = true;
                audioSource.enabled = true;
                audioSource.Play();
            }

            // Call the EndGraceLevel method to check if both candles have been lit
            gameManager.EndGraceLevel();
    }
}
}

