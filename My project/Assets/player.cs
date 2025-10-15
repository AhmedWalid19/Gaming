using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float movespeed;
    public float jumpheight;
    public KeyCode w;
    public KeyCode a;
    public KeyCode d;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(w))
        {
            jump();
        }

        if(Input.GetKeyDown(a))
        {
           GetComponent<Rigidbody2D>().velocity = new Vector2(-movespeed, GetComponent<Rigidbody2D>().velocity.y);
           if(GetComponent<SpriteRenderer>()!=null)
           {
            GetComponent<SpriteRenderer>().flipX= true;
           }
        }

        if(Input.GetKeyDown(d))
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
}
