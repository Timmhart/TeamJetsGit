using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillSchaap : MonoBehaviour
{
    public GameObject enemy;
  void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("axe"))
        {
            Debug.Log("Enemy is dead");
            Destroy(enemy);
        }
    }
}
