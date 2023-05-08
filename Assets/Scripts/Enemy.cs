// // using System.Collections;
// // using System.Collections.Generic;
// // using UnityEngine;

// // public class Enemy : MonoBehaviour
// // {
// //     public Rigidbody2D rigid; // Rigidbody2D of the enemy
// //     public GameObject player;
// //     public float speed; // Movespeed of the enemy


// //     public float distance; // Distance between player and enemy
// //     public float followDistance;

// //     public int damageToGive = 1; // Amount of damage the enemy does

// //     private bool facingRight = true;


// //     private void Start()
// //     {
// //         player = GameObject.Find("Harry");
// //         rigid = GetComponent<Rigidbody2D>();
// //     }

// //     private void FixedUpdate()
// //     {
// //         distance = Vector2.Distance(new Vector2(transform.position.x, 0), new Vector2(player.transform.position.x, 0)); // Calculating the distance between the enemy and the player




// //         if (distance < followDistance && distance > 0.05f) // If the player comes close enough to the enemy
// //         {
// //             if (Mathf.Abs (rigid.velocity.x) >= speed) {								//If sideways velocity is higher than or equal to set movement speed,
// //                 rigid.velocity = new Vector2 (transform.localScale.x * speed, rigid.velocity.y);	// set sideways velocity to movement speed.
// //             } else {
// //                 rigid.AddForce (new Vector2 (transform.localScale.x * (speed * 10f), 0));		//Else add sideways force to player
// //             } 

		
// //             if ((player.transform.position.x > transform.position.x && !facingRight) ||  //If player is moving towards right but is facing left,
// //                 (player.transform.position.x < transform.position.x && facingRight)) {     // or if player is moving towards left but is facing right,
// //                 facingRight = !facingRight;
// //                 Vector3 tempScale = transform.localScale;   // get player scale,
// //                 tempScale.x *= -1;                          // flip x-axis [-1 (left) or 1 (right)],
// //                 transform.localScale = tempScale;           // apply new scale to player.
// //             }
// //         }

// //     }


// //     // private void OnCollisionEnter2D(Collision2D collision)
// //     // {
// //     //     if (collision.gameObject.tag == "Player")
// //     //     {
            
// //     //     }
// //     // }
// // }
// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Enemy : MonoBehaviour
// {
//     public float speed = 3.0f; // Enemy speed
//     public float stoppingDistance = 1.0f; // Distance at which enemy will stop following player
//     public float sightRange = 5.0f; // Maximum distance the enemy can see the player
//     public Transform target; // The player's transform
//     public GameObject enemy;

//     private void Update()
//     {
//         if (target != null)
//         {
//             // Calculate distance to player
//             float distanceToTarget = Vector2.Distance(transform.position, target.position);

//             // Check if player is within range
//             if (distanceToTarget <= sightRange)
//             {
//                 // Calculate direction to player
//                 Vector3 direction = (target.position - transform.position).normalized;
//                 direction.z = 0; // Set z-component to 0

//                 // Move towards player if too far away
//                 if (distanceToTarget > stoppingDistance)
//                 {
//                     transform.position += direction * speed * Time.deltaTime;
//                 }
//             }
//         }
//     }
//     void OnCollisionEnter2D(Collision2D other)
//     {
//         if (other.gameObject.name == "Harry")
//         {
//             Debug.Log("Enemy is dead");
//             Destroy(enemy);
//         }
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
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
        if (other.gameObject.name == "Harry")
        {
            Debug.Log("Enemy is dead");
            Destroy(enemy);
        }
    }
}