using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Collider2D playerCollider;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other == playerCollider) return;
        
        playerMovement.isGrounded = true;    
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other == playerCollider) return;

        playerMovement.isGrounded = false;    
    }

}
