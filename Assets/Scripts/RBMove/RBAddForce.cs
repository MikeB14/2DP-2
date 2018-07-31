using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBAddForce : MonoBehaviour {
    public float ForceMult;
    Rigidbody2D rb;
	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(transform.up * ForceMult);
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, 100);
	}
}
