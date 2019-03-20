using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heroRun : MonoBehaviour
{
    public float upForce = 200f;
    public float runForce = 5f;

    private bool isDead = false;
    private Rigidbody2D rb2d;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isDead == false)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                //rb2d.velocity = Vector2.zero;
                rb2d.AddForce(new Vector2(0, 2*upForce));
                anim.SetTrigger("player_jump");
            }

        }

        rb2d.AddForce(new Vector2(runForce, 0));
        anim.SetTrigger("player_run");
    }
}
