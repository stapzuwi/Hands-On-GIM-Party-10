using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerrb;
    public bool isGrounded = true;
    public bool isDead = false;
    public bool isJumping = false;
    public float jumpForce;
    public GameObject player;
    public float jumpTime;
    private float jumpTimer;
    public Animator animator;
    

    void Start()
    {
        playerrb = GetComponent<Rigidbody2D>();
        jumpForce = 15f;
        jumpTime = 0.2f;
        GameManager.Instance.isPlaying = true;
        animator = GetComponent<Animator>();
    }

    void Update()
    {   
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerrb.velocity = new Vector2(playerrb.velocity.x, jumpForce);
            isJumping = true;
        }
        if (Input.GetKey(KeyCode.Space) && isJumping)
        {
            if (jumpTimer < jumpTime)
            {
                playerrb.velocity += new Vector2(playerrb.velocity.x, jumpForce/100);
                jumpTimer += Time.deltaTime;
            }
            else
            {
                isJumping = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isJumping = false;
            jumpTimer = 0;
        }
        if (isDead)
        {
            Destroy(player);
            enabled = false;
        }
        animator.SetFloat("yVelocity", playerrb.velocity.y);
        animator.SetBool("isGrounded", isGrounded);

    }
}
