using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
  public float speed =2f;
    public float jumpseed = 3f;
    public float doubleJS = 1.5f;

    private bool puedeJS;

    Rigidbody2D rb2D;

    public bool mejorsalto = false;
    public float fallMultiplier = 0.5f;
    public float lowMultiplier = 1f;

    public SpriteRenderer spriteRenderer;
    public Animator animator;


    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKey("w"))
        {
            if (CheckGround.isGrounded)
            {
                puedeJS = true;
                rb2D.velocity = new Vector2(rb2D.velocity.x, jumpseed);
            }
            else
            {
                if(Input.GetKeyDown("w"))
                {
                    if(puedeJS)
                    {
                        animator.SetBool("DoubleJump", true);
                        rb2D.velocity = new Vector2(rb2D.velocity.x, doubleJS);
                        puedeJS = false;
                    }
                }
            }

        }

        if (CheckGround.isGrounded == false)
        {
            animator.SetBool("Jump", true);
            animator.SetBool("Run", false);
        }
        if (CheckGround.isGrounded == true)
        {
            animator.SetBool("Jump", false);
            animator.SetBool("DoubleJump", false);
            animator.SetBool("Falling", false);

        }

        if (rb2D.velocity.y < 0)
        {
            animator.SetBool("Falling", true);
        }
        if (rb2D.velocity.y > 0)
        {
            animator.SetBool("Falling", false);
        }

    }


    void FixedUpdate()
    {
        
        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb2D.velocity = new Vector2(speed, rb2D.velocity.y);
            spriteRenderer.flipX = false;
            animator.SetBool("Run", true);

        }
        else if (Input.GetKey("a") || Input.GetKey("left"))

        {
            rb2D.velocity = new Vector2(-speed, rb2D.velocity.y);
            spriteRenderer.flipX = true;
            animator.SetBool("Run", true);


        }

        else
        {
            rb2D.velocity = new Vector2(0, rb2D.velocity.y);
            animator.SetBool("Run", false);
        }

       
        if (mejorsalto)
        {
            if (rb2D.velocity.y < 0)
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier) * Time.deltaTime;
            }
            if (rb2D.velocity.y > 0 && !Input.GetKey("w"))
            {
                rb2D.velocity += Vector2.up * Physics2D.gravity.y * (lowMultiplier) * Time.deltaTime;
            }
        }
    }


}
