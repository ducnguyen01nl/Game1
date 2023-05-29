using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 velocity = new Vector2(0f, 0f);
    public float pressHorizontal = 0f;
    public float pressVertical = 0f;
    public float speed = 5f;
    public float gameRunningTime = 0f;
    public int increaseCount = 0;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        pressHorizontal = Input.GetAxis("Horizontal");
        pressVertical = 1;
        
    }

    private void FixedUpdate()
    {
        gameRunningTime += Time.fixedDeltaTime;
        velocity.x = pressHorizontal * 10;
        if(increaseCount <1)
        {
            velocity.y = pressVertical * speed;
        }
        UpdateSpeed();
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
    private void UpdateSpeed()
    {
        if (transform.position.x < -3.6 || transform.position.x > 3.6)
        {
            velocity.y = 5;
            increaseCount = 0;

        }

        if (gameRunningTime >= 10)
        {
            UpdateSpeedUp();
            gameRunningTime = 0f; 
        }
    }

    private void UpdateSpeedUp()
    {
        if(increaseCount < 5)
        {
            velocity.y += speed;
            increaseCount++;
        }

    }

   
}
