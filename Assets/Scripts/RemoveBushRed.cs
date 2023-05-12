using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveBushRed : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Bullet"))
        {
            Debug.Log("HALLLLLLOOOOOOOOOOOOO");
            Destroy(gameObject);
        }
    } 
}

