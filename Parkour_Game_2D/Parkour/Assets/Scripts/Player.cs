using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public bool isGrounded;
    public LayerMask whatIsGround;
    public float groundCheckdistance = 2f;
    private float speed = 18f;
    private float jumpforce = 20f;

    public GameObject point;

    public bool playerUnlocked;
    public bool doubleJump;
    public bool isSliding;

    private Vector3 offset;
    public Text doubleJumpPointsText;
    private int dJPoints;

    [SerializeField] private Transform wallcheck;
    [SerializeField] private Vector2 wallcheckSize;
    public bool wallDetected;

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
        if (playerUnlocked && !wallDetected)
            Movement();

        if (isGrounded)
            doubleJump = true;

        CheckCollision();
        CheckInputs();
        Sliding();
    }

    private void Movement()
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }

    private void CheckInputs()
    {
        if (Input.GetButtonDown("Fire1"))
            playerUnlocked = true;

        if (Input.GetButtonDown("Jump"))
            Jump();
        

    }

    private void Sliding()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSliding = true;
            anim.SetBool("isSliding", isSliding);

        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSliding = false;
            anim.SetBool("isSliding", isSliding);

        }
    }

    private void Jump()
    {
        if (isGrounded)
        {

            
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            Debug.Log("jumped");

        }
        else if (doubleJump)
        {
            doubleJump = false;
            rb.velocity = new Vector2(rb.velocity.x, jumpforce);
            dJPoints++;
            doubleJumpPointsText.text = "" + dJPoints;
            Points();
        }
    }

    public void Points()
    {
        offset = new Vector3(11f, -3f, 0f);
        Instantiate(point, transform.position + offset, Quaternion.identity);
    }


    public void CheckCollision()
    {
        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, groundCheckdistance, whatIsGround);
        wallDetected = Physics2D.BoxCast(wallcheck.position, wallcheckSize, 0, Vector2.zero, whatIsGround);
    }

    public void AnimatorController()
    {

        anim.SetBool("isDoubleJump", doubleJump);
        anim.SetBool("isGrounded", isGrounded);
        anim.SetFloat("xVelocity", rb.velocity.x);
        anim.SetFloat("yVelocity", rb.velocity.y);
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, new Vector2(transform.position.x, transform.position.y - groundCheckdistance));
        Gizmos.DrawWireCube(wallcheck.position, wallcheckSize);
    }
    
    
}
