using UnityEngine;

public class Candle : MonoBehaviour
{
    // private bool isLit = false;
    public GameObject prefab; // the prefab to instantiate on collision

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Instantiate(prefab, transform.position, transform.rotation); // instantiate the prefab at the same position and rotation as the original object
            Destroy(gameObject); // destroy the original object
        }
    }
}

