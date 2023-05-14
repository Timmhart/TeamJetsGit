using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSchaap : MonoBehaviour
{
    public GameObject enemy;
    public GameObject sheepBlood;
    public GameObject quest1;
    public GameObject quest2;

    void Awake()
    {
        sheepBlood.SetActive(false);
        quest1.SetActive(true);
        quest2.SetActive(false);
    }
  void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("axe"))
        {
            Debug.Log("Enemy is dead");
            Destroy(enemy);
            sheepBlood.SetActive(true);
            quest1.SetActive(false);
            quest2.SetActive(true);

        }
    }
}
