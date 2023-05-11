using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScript : MonoBehaviour
{  
    public HealthScript healthScript;
    public int damage = 1;
  

  private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            Debug.Log("You got hit");
            healthScript.TakeDamage(damage);
            // damageSoundEffect.Play();
        }
    }
}
