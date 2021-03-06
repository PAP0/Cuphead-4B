﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    #region Variables

    [SerializeField] GameObject Player;
    Rigidbody2D PlayerRb;
    [SerializeField] float speed;
    [SerializeField]  public float currentspeed;
    [SerializeField] float dash;
    [SerializeField] float jumpForce;
    public float horizontal;
    bool isGrounded = false;
    [SerializeField] Transform isGroundedChecker;
    [SerializeField] float checkGroundRadius;
    [SerializeField] LayerMask groundLayer;
    public float jumpTimeCounter;
    public float jumpTime;
    public bool facingRight = true;
    bool isCrouching;
    private bool isJumping;
    Animator anim;

    #endregion

    #region Functions
	
    void Start()
    {   
        PlayerRb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKey("c"))
        {
            Debug.Log("C pressed");
            Crouch();
            CheckIfGrounded();
        }
        else
        {
        currentspeed = Input.GetAxisRaw("Horizontal") * speed;
        Move();
        Jump();
        CheckIfGrounded();
        Crouch();
        anim.SetFloat("Speed", Mathf.Abs(currentspeed));
        //Debug.Log(currentspeed);
        //Dash();  
        }
  
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        Flip(horizontal);
    }

    void Flip(float horizontal)
    {
        if(horizontal>0 && !facingRight || horizontal<0 && facingRight)
        {
            facingRight = !facingRight;
            //Vector3 theScale = transform.localScale;
            //theScale.x *= -1;
            //transform.localScale = theScale;
            transform.Rotate(0f, 180f, 0f);
        }
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float moveBy = x * speed;
        PlayerRb.velocity = new Vector2(moveBy, PlayerRb.velocity.y);
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if(isGrounded == true)
            {
                anim.SetBool("isWalking", true);
            }
        }
        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
        {
            anim.SetBool("isWalking", false);
        }
    }

    void Crouch()
    {
        if(Input.GetKeyDown(KeyCode.DownArrow) && isGrounded == true)
        {
            anim.SetBool("isCrouching", true);
            speed = 0;
            isCrouching = true;
        }
        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            anim.SetBool("isCrouching", false);
            speed = 13;
            isCrouching = false;
        }
    }

    void Dash()//not used
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            PlayerRb.constraints = RigidbodyConstraints2D.FreezePositionY;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            PlayerRb.constraints = RigidbodyConstraints2D.None;
            PlayerRb.constraints = RigidbodyConstraints2D.FreezeRotation;
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Z) && isGrounded && isCrouching == false)
        {
            isJumping = true;
            jumpTimeCounter = jumpTime;
            PlayerRb.velocity = new Vector2(PlayerRb.velocity.x, jumpForce);
        }

        if (Input.GetKey(KeyCode.Z) && isJumping == true && isGrounded == false)
        {
            if(jumpTimeCounter > 0)
            {
                PlayerRb.velocity = new Vector2(PlayerRb.velocity.x, jumpForce);
                jumpTimeCounter -= Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
        if(isGrounded == false)
        {
            anim.SetBool("isJumping", true);
            anim.SetBool("isWalking", false);
        }
        else
        {
            anim.SetBool("isJumping", false);
        }
    }
    public void GettingHit()
    {
        anim.Play("GettingHit");
        
    }

    void CheckIfGrounded()
    {
        Collider2D collider = Physics2D.OverlapCircle(isGroundedChecker.position, checkGroundRadius, groundLayer);
        isGrounded = collider != null ? true : false;
    }
   

    #endregion
}