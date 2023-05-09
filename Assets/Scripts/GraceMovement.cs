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
    //    mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    //     // Get the direction to look towards (i.e. the mouse position)
    //         Vector2 lookDir2 = mousePos - rb.position;
    //         float angle2 = Mathf.Atan2(lookDir2.y, lookDir2.x) * Mathf.Rad2Deg - 90f;
    //         rb.rotation = angle2;

    //         // Calculate the movement vector based on the look direction and the "W" key input
    //         Vector2 movement_Player2 = lookDir2.normalized * Input.GetAxisRaw("Vertical_Player2");

    //         // Move player 2 based on the movement vector
    //         rb.MovePosition(rb.position + movement_Player2 * moveSpeed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}