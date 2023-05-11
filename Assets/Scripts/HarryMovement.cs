using UnityEngine;

public class HarryMovement : MonoBehaviour
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
            movement.x = Input.GetAxisRaw("HorizontalHarry");
            movement.y = Input.GetAxisRaw("VerticalHarry");

            animator.SetFloat("HorizontalHarry", movement.x);
            animator.SetFloat("VerticalHarry", movement.y);
            animator.SetFloat("SpeedHarry", movement.sqrMagnitude);
    }

      void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}