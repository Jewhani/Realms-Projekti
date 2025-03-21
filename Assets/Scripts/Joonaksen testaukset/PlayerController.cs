using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public Vector3 groundCheckerPosition;
    //public Vector2 groundCheckRadius;
    Rigidbody2D rb;
    public bool isGrounded;
    bool pull;
    public float runSpeed = 5f;
    public float jumpForce = 10f;
    Animator anim;
    //SpriteRenderer rend;
    float movementX;


    void Start()
    {
        // rend = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GameManager.gameRunning)
        {
            anim.SetFloat("Speed", Mathf.Abs(rb.linearVelocity.x));
            anim.SetBool("IsGrounded", isGrounded);
            Move();
            Jump();
            //CheckIfGrounded();
        }
    }

    void Move()
    {
        movementX = Input.GetAxisRaw("Horizontal");


        rb.linearVelocity = new Vector2(movementX * runSpeed, rb.linearVelocity.y);

        if (movementX > 0.1f)
        {
            transform.localScale = new Vector2(1, 1);
        }

        if (movementX < -0.1f)
        {
            transform.localScale = new Vector2(-1, 1);
        }


    }

    void Jump()
    {

        if (Input.GetButton("Jump") && isGrounded == true)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            pull = false;
        }

        if (rb.linearVelocity.y < 0 && pull == false)
        {
            rb.AddForce(Vector2.down * 200);
            pull = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (!collision.isTrigger)
        {
            isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isGrounded = false;
    }

    //    void CheckIfGrounded()
    //    {
    //        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
    //
    //        if (collider != null)
    //        {
    //            isGrounded = true;
    //        }
    //        else
    //        {
    //            isGrounded = false;
    //        }
    //    }
}
