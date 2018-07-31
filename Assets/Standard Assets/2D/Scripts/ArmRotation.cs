using UnityEngine;
using System.Collections;

public class ArmRotation : MonoBehaviour {

	public int rotationOffset = 90;
    public Transform Aimer;

	// Update is called once per frame
	void Update () {
		// subtracting the position of the player from the mouse position
        Vector3 difference = Camera.main.ScreenToWorldPoint (Input.mousePosition) - transform.position;
		difference.Normalize ();		// normalizing the vector. Meaning that all the sum of the vector will be equal to 1

        float rotZ = Mathf.Atan2 (/*difference.y, difference.x*/Aimer.position.y, Aimer.position.x) * Mathf.Rad2Deg;	// find the angle in degrees
		transform.rotation = Quaternion.Euler (0f, 0f, rotZ + rotationOffset);
	}
}
