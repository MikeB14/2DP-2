using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEffect : MonoBehaviour {


	public int SDT = 0;
	public int Destroy;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SDT++;

		if (SDT >= Destroy){
			Destroy(gameObject);
		}
	}
}
