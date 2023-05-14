using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBos : MonoBehaviour
{
    // public GameObject quest0;
    public float speed = 3.0f; // Enemy speed
    public float stoppingDistance = 1.0f; // Distance at which enemy will stop following target
    public float sightRange = 5.0f; // Maximum distance the enemy can see the target
    public Transform target1; // The first target's transform
    public Transform target2; // The second target's transform
    public GameObject enemy;

    private void Update()
    {
        if (target1 != null && target2 != null)
        {
            // Calculate distance to target1
            float distanceToTarget1 = Vector2.Distance(transform.position, target1.position);
            // Calculate distance to target2
            float distanceToTarget2 = Vector2.Distance(transform.position, target2.position);

            // Check if either target is within range
            if (distanceToTarget1 <= sightRange || distanceToTarget2 <= sightRange)
            {
                Transform target = distanceToTarget1 < distanceToTarget2 ? target1 : target2;
                // Calculate direction to target
                Vector3 direction = (target.position - transform.position).normalized;
                direction.z = 0; // Set z-component to 0

                // Move towards target if too far away
                if (distanceToTarget1 > stoppingDistance && distanceToTarget2 > stoppingDistance)
                {
                    transform.position += direction * speed * Time.deltaTime;
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("axe"))
        {
            Debug.Log("Enemy is dead");
            Destroy(enemy);
        }
    }
}