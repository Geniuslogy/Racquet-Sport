using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    Rigidbody2D rigidbody2D;

    public float force;

    bool IsPlay;


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
        
        if (!IsPlay) {
            
            if (Input.anyKeyDown)
            {
                
                Bounce();

                IsPlay = true;

                GameManager.instance.Play();

            }

        }

    }

    void Bounce()
    {
        // The X is a random value between -1 to 1 and Y is equal to 1.
        Vector2 direction = new Vector2(Random.Range(-1, 1), 1);

        rigidbody2D.AddForce(direction * force, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "GameRestartCheck")
        {
            GameManager.instance.Restart();
        }

        else if (collision.gameObject.tag == "Paddle")
        {
            GameManager.instance.Score();
        }

    }

}
