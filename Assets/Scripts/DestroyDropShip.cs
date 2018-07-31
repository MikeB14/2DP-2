using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyDropShip : MonoBehaviour {


    public int DestroyTimer;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        DestroyTimer++;
        if (DestroyTimer == 50){
            Destroy(gameObject);
        }
		
	}
}
