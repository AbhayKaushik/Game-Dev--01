﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle : MonoBehaviour
{
    public GameObject Hero;
    
    //private Animator animtext;


    //  private void OnTriggerEnter2D(Collider2D other)
    //  {
    //      if(other.GetComponent<heroRun>() != null)
    //     {
    //         print("AAAA");
    //      }
    //
    //  }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Hero")
        {
            print("Its working");
            GameController.instance.gameOver = true;
            GameController.instance.HeroDied();
            //isDeadTrue();
        }

    }

}
