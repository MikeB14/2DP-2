using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RBDropShip : MonoBehaviour {

    public float ForceMult;
    Rigidbody2D rb;
    // Use this for initialization
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //  rb.velocity = transform.right * Time.deltaTime * ForceMult;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0, 75) * Time.deltaTime);
    }
}
