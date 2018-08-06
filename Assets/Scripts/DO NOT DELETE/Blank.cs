using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Blank : MonoBehaviour {

    public int Speed;
    private Rigidbody2D RB;
    private Vector2 MoveVelocity;

	// Use this for initialization
	void Start () {
        RB = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Translate(Speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, Speed * Input.GetAxis("Vertical") * Time.deltaTime);

        Vector2 MoveInput = new Vector2(Input.GetAxis("AimHorizontal"), Input.GetAxis("AimVertical"));
        MoveVelocity = MoveInput.normalized * Speed;
	}

    private void FixedUpdate()
    {
        RB.MovePosition(RB.position + MoveVelocity * Time.fixedDeltaTime);
    }
}
