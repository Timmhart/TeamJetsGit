// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ShootingGrace1 : MonoBehaviour
// {
//     public Transform firePoint;
//     public GameObject bulletPrefab;
//     public float bulletForce = 20f;
//     public float bulletLifetime = 1f; // Time until bullet is destroyed
//     // public static ShootingGrace1 shootingGrace;

//     public void Start()
//     {
//         // shootingGrace = this;
//     }

//     // Update is called once per frame
//     public void Update()
//     {
//         if (Input.GetButtonDown("Fire1"))
//         {
//             Shoot();
//         }
//     }

//     public void Shoot()
//     {
//         // Get the mouse position in world coordinates
//         Vector3 mousePos = Input.mousePosition;
//         mousePos.z = -Camera.main.transform.position.z;
//         mousePos = Camera.main.ScreenToWorldPoint(mousePos);

//         // Calculate the direction from the fire point to the mouse position
//         Vector2 direction = (mousePos - firePoint.position).normalized;

//         // Instantiate the bullet
//         GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

//         // Set the velocity of the bullet based on the direction and force
//         Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
//         rb.velocity = direction * bulletForce;

//         // Destroy bullet after specified lifetime
//         Destroy(bullet, bulletLifetime);
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingGrace1 : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public float bulletForce = 20f;
    public float bulletLifetime = 1f;

    private GameObject playerObject;
    private Collider2D playerCollider;

    private void Start()
    {
        playerObject = GameObject.FindWithTag("Grace");
        playerCollider = playerObject.GetComponent<Collider2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        mousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 direction = (mousePos - firePoint.position).normalized;

        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.velocity = direction * bulletForce;

        Physics2D.IgnoreCollision(bullet.GetComponent<Collider2D>(), playerCollider);

        Destroy(bullet, bulletLifetime);
    }
}