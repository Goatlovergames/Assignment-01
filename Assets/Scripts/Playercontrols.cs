using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontrols : MonoBehaviour {

    Rigidbody2D rb2d;
    public float speed;
    Animator ani;

    public Sprite main; 
	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        rb2d.velocity = new Vector2(0,0);
        ani.enabled = false;

        if (Input.GetKey("w"))
        {
            rb2d.velocity = new Vector2(0,speed);
        }
        else if (Input.GetKey("s"))
        {
            ani.enabled = enabled;
            rb2d.velocity = new Vector2(0, -speed);
        }
        else if (Input.GetKey("d"))
        {
            rb2d.velocity = new Vector2(speed, 0);
        }
        else if (Input.GetKey("a"))
        {
            rb2d.velocity = new Vector2(-speed, 0);
        }
        
    }
}
