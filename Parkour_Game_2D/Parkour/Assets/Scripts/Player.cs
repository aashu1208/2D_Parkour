using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool isGrounded;
    public LayerMask whatIsGround;
    public float groundCheckdistance = 2f;
    private float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void FixedUpdate()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckdistance, whatIsGround);
        if (Input.GetKey(KeyCode.D))
        {

            rb.velocity = new Vector2(speed, rb.velocity.y);
            
        }
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);
            Debug.Log("jumped");
        }

        
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
