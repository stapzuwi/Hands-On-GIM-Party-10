using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    public Rigidbody2D obsrb;
    public PlayerMovement playerMovement;

    void Start()
    {
        obsrb = GetComponent<Rigidbody2D>();
        obsrb.velocity = new Vector2(-8,obsrb.velocity.y);
    }

    void Update()
    {  
        if (playerMovement.isDead == true)
        {
            obsrb.velocity = new Vector2(0,0);
        }
    }
}
