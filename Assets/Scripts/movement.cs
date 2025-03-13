
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float SpeedValue;    
    public float JumpForce = 5f;  
    public LayerMask GroundLayer; 

    private bool isGrounded;

    private Rigidbody2D rb;  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
      
        transform.position += Vector3.right * SpeedValue * Time.deltaTime;

       
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }

      
        isGrounded = Physics2D.OverlapCircle(transform.position - Vector3.up * 0.5f, 0.1f, GroundLayer);
    }

    void Jump()
    {


        rb.linearVelocity = new Vector2(rb.linearVelocity.x, JumpForce);
    }
}

