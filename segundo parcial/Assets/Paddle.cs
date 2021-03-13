using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isPlayer1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;


    private float movement;
    private float movement2;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {


            if (isPlayer1)
            {
                movement = Input.GetAxisRaw("Vertical");

                if (transform.position.x < -0.8 && transform.position.x > -8.7)
                {
                    movement2 = Input.GetAxisRaw("Horizontal");
                }

                else if (transform.position.x >= -0.8)
                {
                    if (Input.GetAxisRaw("Horizontal") < 0)
                    {
                        movement2 = Input.GetAxisRaw("Horizontal");
                    }
                    else
                    {
                        movement2 = 0;
                    }

                }
                else if (transform.position.x <= -8.7)
                {
                    if (Input.GetAxisRaw("Horizontal") > 0)
                    {
                        movement2 = Input.GetAxisRaw("Horizontal");
                    }
                    else
                    {
                        movement2 = 0;
                    }

                }


            }
            else
            {
                movement = Input.GetAxisRaw("Vertical2");

                if (transform.position.x > 0.8 && transform.position.x < 8.7)
                {
                    movement2 = Input.GetAxisRaw("Horizontal2");
                }
                else if (transform.position.x <= 0.8)
                {
                    if (Input.GetAxisRaw("Horizontal2") > 0)
                    {
                        movement2 = Input.GetAxisRaw("Horizontal2");
                    }
                    else
                    {
                        movement2 = 0;
                    }
                }
                else if (transform.position.x >= 8.7)
                {
                    if (Input.GetAxisRaw("Horizontal2") < 0)
                    {
                        movement2 = Input.GetAxisRaw("Horizontal2");
                    }
                    else
                    {
                        movement2 = 0;
                    }

                }

            }

            rb.velocity = new Vector2(movement2 * speed, movement * speed);
       

    }

   

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
