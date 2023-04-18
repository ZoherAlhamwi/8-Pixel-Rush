using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    public float jump;

    public bool Jumping;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isGrounded;
    private float horizontalInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");


        // flip player sprite based on movement direction
        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3(2, 2, 2);
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3(-2, 2, 2);
        }

        // player jump
           if(Input.GetButtonDown("Jump") && Jumping == false) { 
            rb.AddForce(new Vector2(rb.velocity.x, jump));
            animator.SetBool("isJumping", true);

        }



        // play running animation if player is moving
        animator.SetBool("isRunning", horizontalInput != 0);
    }

    void FixedUpdate()
    {
        // player movement
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }

    // player is grounded
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Jumping = false;
            animator.SetBool("isJumping", false);

        }
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            Jumping = true;

        }
    }

}
