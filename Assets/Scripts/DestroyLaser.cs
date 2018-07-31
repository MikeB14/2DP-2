using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLaser : MonoBehaviour {

    int DestroyTimer;

	void Start()
	{
		
	}
	void Update()
	{
        DestroyTimer++;

        if(DestroyTimer == 50){
            Destroy(gameObject);
        }
		
	}

}

