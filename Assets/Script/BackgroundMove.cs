using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMove : MonoBehaviour
{
    [SerializeField] private float startPos;
    [SerializeField] private float endPos;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2 (-8*GameManager.Instance.gameSpeed/5,0);
        if (transform.position.x <= endPos)
        {
            transform.position = new Vector2 (startPos, transform.position.y);
        }
    }
}
