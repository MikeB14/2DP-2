using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {


	public Transform ShootEffect;
	public Transform Laser;
	public int ShootTimer;
	public Transform FirePoint;
	public Transform EffectPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		ShootTimer++;
		Shoot();
	}

	void Shoot(){
		if (ShootTimer >= 100){
			Instantiate(ShootEffect, EffectPoint.position, EffectPoint.rotation);
			Instantiate(Laser, FirePoint.position, FirePoint.rotation);
			ShootTimer = 0;
		}
	}
}
