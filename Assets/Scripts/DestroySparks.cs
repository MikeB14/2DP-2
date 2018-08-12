using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySparks : MonoBehaviour {

    public int SDT;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        SDT++;

        if(SDT >= 100)
        {
            Destroy(gameObject);
        }
	}
}
