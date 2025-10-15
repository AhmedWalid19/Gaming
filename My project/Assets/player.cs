using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float movespeed;
    public float jumpheight;
    public KeyCode spacebar;
    public KeyCode left;
    public KeyCode right;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(spacebar) && grounded)
        {
            jump();
        }

        if(Input.GetKeyDown(left))
        {
           GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
           if(GetComponent<SpriteRenderer>()!=null)
           {
            GetComponent<SpriteRenderer>().flipX= true;
           }
        }

        if(Input.GetKeyDown(right))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(movespeed, GetComponent<Rigidbody2D>().velocity.y);

            if(GetComponent<SpriteRenderer>()!=null)
           {
            GetComponent<SpriteRenderer>().flipX= false;
           }
        }
    }

    void jump()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpheight);
    }
    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
    }

}
