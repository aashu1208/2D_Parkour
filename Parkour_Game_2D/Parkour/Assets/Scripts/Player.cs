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
    private float speed = 6f;
    private float jumpforce = 15f;
    public bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {

        CheckCollision();
        CheckInputs();

    }

    private void CheckInputs()
    {
        if (Input.GetKey(KeyCode.D))
        {

            rb.velocity = new Vector2(speed, rb.velocity.y);

        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            Debug.Log("jumped");
        }
    }

    public void CheckCollision()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckdistance, whatIsGround);
    }

    public void AnimatorController()
    {
        isRunning = rb.velocity.x != 0;
        anim.SetBool("isRunning", isRunning);
        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("yVelocity", rb.velocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - groundCheckdistance));
    }
    // Update is called once per frame
    void Update()
    {
        AnimatorController();
        
    }
}
