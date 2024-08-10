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
    private float speed = 12f;
    private float jumpforce = 15f;

    public bool playerUnlocked;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        
        AnimatorController();
        if (playerUnlocked)
            rb.velocity = new Vector2(speed, rb.velocity.y);

        CheckCollision();
        CheckInputs();
    }

    private void CheckInputs()
    {
        if (Input.GetButtonDown("Fire1"))
            playerUnlocked = true;

        if (Input.GetButtonDown("Jump") && isGrounded)
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            Debug.Log("jumped");
    }

    public void CheckCollision()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckdistance, whatIsGround);
    }

    public void AnimatorController()
    {
        
        
        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("xVelocity", rb.velocity.x);
        anim.SetFloat("yVelocity", rb.velocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - groundCheckdistance));
    }
    
    
}
