using UnityEngine;

public class TraliesMorphen : MonoBehaviour
{
    // private bool isLit = false;
    public GameObject prefab; // the prefab to instantiate on collision
    public GameObject quest1;
    public GameObject quest2;

    void Awake()
    {
        quest1.SetActive(true);
        quest2.SetActive(false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("Tralies gemorphed");
            Instantiate(prefab, transform.position, transform.rotation);
            Destroy(gameObject);  
            quest1.SetActive(false);
            quest2.SetActive(true);
        }
    }
}

