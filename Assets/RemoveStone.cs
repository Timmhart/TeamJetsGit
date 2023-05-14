using UnityEngine;

public class RemoveStone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Stone removed");
            // Instantiate(prefab, transform.position, transform.rotation);
            Destroy(gameObject);  
        }
    }
}

