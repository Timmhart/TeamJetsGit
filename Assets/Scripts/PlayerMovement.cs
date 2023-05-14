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
        rbHarry.mass = 0;
        rbGrace.mass = 1000; 
        cameraGrace.SetActive(false);
        cameraHarry.SetActive(true);
        imageGrace.SetActive(false);
        imageHarry.SetActive(true);
        GameManager2.instance.shootingGrace.enabled = false;
        GameManager2.instance.shootingHarry.enabled = true;
    }

    void Update()
    {
            
        if (Input.GetKeyDown(KeyCode.LeftShift))
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
                GameManager2.instance.shootingGrace.enabled = false;
                GameManager2.instance.shootingHarry.enabled = true;
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
                GameManager2.instance.shootingGrace.enabled = true;
                GameManager2.instance.shootingHarry.enabled = false;
                
            }
        }
            movementHarry.x = Input.GetAxisRaw("HorizontalHarry");
            movementHarry.y = Input.GetAxisRaw("VerticalHarry");
            movementGrace.x = Input.GetAxisRaw("HorizontalGrace");
            movementGrace.y = Input.GetAxisRaw("VerticalGrace");
            
        if(!isFrozen_Player1)
        {
                animatorHarry.SetFloat("HorizontalHarry", movementHarry.x);
                animatorHarry.SetFloat("VerticalHarry", movementHarry.y);
                animatorHarry.SetFloat("SpeedHarry", movementHarry.sqrMagnitude);  
                rbGrace.mass = 1000;
                rbHarry.mass = 0;
        }
        else 
        {
            animatorGrace.SetFloat("HorizontalGrace", movementGrace.x);
            animatorGrace.SetFloat("VerticalGrace", movementGrace.y);
            animatorGrace.SetFloat("SpeedGrace", movementGrace.sqrMagnitude);  
            rbHarry.mass = 1000;
            rbGrace.mass = 0;
        }        
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movementHarry * speed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + movementGrace * speed * Time.fixedDeltaTime);
    } 
}