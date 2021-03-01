using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    Rigidbody2D rigidbody2D;

    public float speed;


    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {

        if (Input.GetMouseButton(0))
        {
            Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (position.x < 0)
            {
                // Move paddle to the left.
                rigidbody2D.velocity = Vector2.left * speed;
            } 
            else
            {
                rigidbody2D.velocity = Vector2.right * speed;
            }

        }
        else
        {
            rigidbody2D.velocity = Vector2.zero;
        }

    }

}
