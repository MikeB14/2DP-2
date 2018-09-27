using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class JoyRotate : MonoBehaviour {

    public float Speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {


        Vector2 Direction = new Vector2(Input.GetAxis("AimHorizontal"), Input.GetAxis("AimVertical")) * Speed;
        transform.right = Direction;
        transform.rotation = transform.rotation;


    }
}
