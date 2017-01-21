using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingArm : MonoBehaviour {


	public Transform hitPoint;

	public bool direction;

	public int posOffset;

	public Camera cam;


	void Start () {
		direction = true;
	}
	
	// Update is called once per frame
	void Update () {


		Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5f;

	

		mousePos.x = mousePos.x;
		mousePos.y = mousePos.y;

		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
//
//		if (direction == true) {
//			posOffset = 75;
//		}
//
//		if (direction == false) {
//			posOffset = 110;
//		}

		transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle + posOffset));






	}
}
