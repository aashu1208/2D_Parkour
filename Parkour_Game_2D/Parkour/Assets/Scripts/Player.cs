using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public bool isGrounded;
    public LayerMask whatIsGround;
    public float groundCheckdistance = 2f;
    private float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckdistance, whatIsGround);
        if (Input.GetKey(KeyCode.D))
        {

            rb.velocity = new Vector2(speed, rb.velocity.y);

        }
        Jump();

    }

    private void Jump()
    {
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
            Debug.Log("jumped");
        }
    }

    public void CheckCollision()
    {

    }

    public void CheckInput()
    {


    }

    public void AnimatorController()
    {
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - groundCheckdistance));
    }
    // Update is called once per frame
    void Update()
    {
        
         
    }
}
