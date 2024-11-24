using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerrb;
    public bool isGrounded;
    public bool isDead;
    public GameObject player;
    

    void Start()
    {
        playerrb = GetComponent<Rigidbody2D>();
        isGrounded = true;
        isDead = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerrb.velocity = new Vector2(playerrb.velocity.x, 15);
        }
        if (isDead)
        {
            enabled = false;
        }
    }
}
