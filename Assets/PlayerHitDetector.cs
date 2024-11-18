using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitDetector : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Collider2D playerCollider;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other == playerCollider)
        {
            playerMovement.isDead = true;    
        }
    }

}
