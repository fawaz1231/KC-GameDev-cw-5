using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    Rigidbody2D RB;
    float playerinput;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }
    
    private void FixedUpdate()
    {
       move();
    }

    void move()
    { 
        playerinput = Input.GetAxis("Horizontal");
        RB.velocity = new Vector2(playerinput * speed, 0);
    }
     
      private void OnTriggeEnter2D(Collider2D collision)
      {
         print("Collision Detected");
      }

}
