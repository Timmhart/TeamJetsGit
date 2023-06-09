using UnityEngine;

public class GraceMovement : MonoBehaviour
{
    public float speed = 1f;

    private Rigidbody2D rb;
    private Vector2 movement;
    public Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
            movement.x = Input.GetAxisRaw("HorizontalGrace");
            movement.y = Input.GetAxisRaw("VerticalGrace");

            animator.SetFloat("HorizontalGrace", movement.x);
            animator.SetFloat("VerticalGrace", movement.y);
            animator.SetFloat("SpeedGrace", movement.sqrMagnitude);
    }

      void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}