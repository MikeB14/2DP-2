using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

	public int Lives = 3;

	

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	if(Lives == 0){
		print ("Player is dead");
	}
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Laser" && Lives == 3)
        {
            Lives = 2;
        }
        else if (collision.gameObject.tag == "Laser" && Lives == 2)
        {
            Lives = 1;
        }
        else if (collision.gameObject.tag == "Laser" && Lives == 1)
        {
            Lives = 0;
        }
    }
}
