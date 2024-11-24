using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HitDetector : MonoBehaviour

{
    public PlayerMovement playerMovement;
    public Collider2D playerCollider;
    public string Scene;
    
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.tag == "Obstacle")
        {
            playerMovement.isDead = true; 
            SceneManager.LoadScene(Scene);
        }
    }
}
