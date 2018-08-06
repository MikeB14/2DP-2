using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;
using UnityStandardAssets.CrossPlatformInput;

public class CameraShake : MonoBehaviour {

	private int ShakeCount = 0;
	private Animator Anim;

	// Use this for initialization
	void Start () {
		Anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Shake(){
		if(CrossPlatformInputManager.GetButtonDown("Fire1") && ShakeCount == 0){
		Anim.SetTrigger("CameraShake1");
	}
	else if(CrossPlatformInputManager.GetButtonDown("Fire1") && ShakeCount == 1){
		Anim.Play("CameraShake2");
	}
	else if(CrossPlatformInputManager.GetButtonDown("Fire1") && ShakeCount == 2){
		Anim.Play("CameraShake3");
	}
	else if (CrossPlatformInputManager.GetButtonDown("Fire1") && ShakeCount == 3){
		Anim.Play("CameraShake4");
		ShakeCount = 0;
	}
	else {
		Anim.Play("CameraIdle");
	}
}
}

