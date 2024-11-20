using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHitDetector : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public Collider2D playerCollider;
    public string Scene;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other == playerCollider)
        {
            playerMovement.isDead = true; 
            SceneManager.LoadScene(Scene);
        }
    }

}
