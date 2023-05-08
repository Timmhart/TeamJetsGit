using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    public Animator animatorHarry;
    public Animator animatorGrace;
    private Rigidbody2D rb;
    private Rigidbody2D rbHarry;
    private Rigidbody2D rbGrace;
    public GameObject cameraHarry;
    public GameObject cameraGrace;
    public GameObject imageHarry;
    public GameObject imageGrace;
    public Camera camHarry;
    public Camera camGrace;
    // Vector2 mousePos;
    Vector2 movementGrace;

    Vector2 movementHarry;

    private bool isFrozen_Player1 = false;

    void Start()
    {
        rbHarry = GameObject.FindGameObjectWithTag("Harry").GetComponent<Rigidbody2D>();
        rbGrace = GameObject.FindGameObjectWithTag("Grace").GetComponent<Rigidbody2D>();
        rb = rbHarry;
        cameraGrace.SetActive(false);
        cameraHarry.SetActive(true);
        imageGrace.SetActive(false);
        imageHarry.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isFrozen_Player1)
            {
                cameraHarry.SetActive(true);
                cameraGrace.SetActive(false);
                imageHarry.SetActive(true);
                imageGrace.SetActive(false);
                isFrozen_Player1 = false;
                rbGrace.velocity = Vector2.zero;
                rb = rbHarry;   
                animatorHarry.SetFloat("HorizontalHarry", movementHarry.x);
                animatorHarry.SetFloat("VerticalHarry", movementHarry.y);
                animatorHarry.SetFloat("SpeedHarry", movementHarry.sqrMagnitude); 
                 
            }
            else
            {
                cameraHarry.SetActive(false);
                cameraGrace.SetActive(true);
                imageHarry.SetActive(false);
                imageGrace.SetActive(true);
                isFrozen_Player1 = true;
                rbHarry.velocity = Vector2.zero;
                rb = rbGrace;
                animatorGrace.SetFloat("HorizontalGrace", movementGrace.x);
                animatorGrace.SetFloat("VerticalGrace", movementGrace.y);
                animatorGrace.SetFloat("SpeedGrace", movementGrace.sqrMagnitude);
               
            }
        }
            movementHarry.x = Input.GetAxisRaw("HorizontalHarry");
            movementHarry.y = Input.GetAxisRaw("VerticalHarry");
            movementGrace.x = Input.GetAxisRaw("HorizontalGrace");
            movementGrace.y = Input.GetAxisRaw("VerticalGrace");

             
             

            
    }

    void FixedUpdate()
    {
    //     if (isFrozen_Player1)
    //     {
    //         mousePos = camGrace.ScreenToWorldPoint(Input.mousePosition);
            
    //     }
    //    else 
    //    {
    //         mousePos = camHarry.ScreenToWorldPoint(Input.mousePosition);
    //    }
       

        // Get the direction to look towards (i.e. the mouse position)
            // Vector2 lookDir2 = mousePos - rb.position;
            // float angle2 = Mathf.Atan2(lookDir2.y, lookDir2.x) * Mathf.Rad2Deg - 90f;
            // rb.rotation = angle2;

            // // Calculate the movement vector based on the look direction and the "W" key input
            // Vector2 movement_Player2 = lookDir2.normalized * Input.GetAxisRaw("Vertical_Player2");

            // // Move player 2 based on the movement vector
            // rb.MovePosition(rb.position + movement_Player2 * moveSpeed * Time.fixedDeltaTime);
          
           
        // calculate the movement vector
        // Vector2 movement = new Vector2(horizontal, vertical).normalized * speed;

        // apply the movement to the Rigidbody2D component
        rb.MovePosition(rb.position + movementHarry * speed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + movementGrace * speed * Time.fixedDeltaTime);
    } 
}