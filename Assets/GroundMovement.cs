using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour
{
    public float startX;
    public float endX;
    public Rigidbody2D grb;

    void Start()
    {
        grb = GetComponent<Rigidbody2D>();
        startX = 0f;
        endX = -39.49f;
    }

    void Update()
    {
        grb.velocity = new Vector2(-8*GameManager.Instance.gameSpeed,0);
        if (transform.position.x <= endX)
        {
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos; 
        }
    }
}
