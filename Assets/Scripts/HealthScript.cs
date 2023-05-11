using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthScript : MonoBehaviour
{

    public int health;
    public int maxHealth = 1;
    public SpriteRenderer playerHarry;
    public SpriteRenderer playerGrace;
    // public PlayerControllerSuperBasic playerMovement;
    // private bool isDead;
    // public GameManager gameManager;
    // [SerializeField] private AudioSource deathSoundEffect;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int amount)
    {
        health -= amount;
        if(health <= 0)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //    deathSoundEffect.Play();
        }
    }
}
