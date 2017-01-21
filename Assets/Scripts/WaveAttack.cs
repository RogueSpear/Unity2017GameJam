using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveAttack : MonoBehaviour {

	public Transform firePoint;

	public GameObject waveAttack;

	void Update (){

		if (Input.GetMouseButtonDown (0)) {

			Instantiate (waveAttack, firePoint.position, firePoint.rotation);
		}
	}













}

//	public float fireRate;
//
//	public RotatingArm script;
//
//	public Transform firePoint;
//
//	public Transform bulletPre;
//
//	private float timeToFire = 0f;
//
//
//	void Update (){
//
//		if (firePoint == null) {
//
//			Shoot ();
//		} 
//
//		else {
//
//			if (Input.GetMouseButton(0) && Time.deltaTime > timeToFire) {
//
//				timeToFire = Time.time + 1 / fireRate;
//
//				Shoot ();
//
//			}
//
//		}
//	}
//
////	void Shoot(){
////
////		Debug.Log (firePoint.rotation + "Test");
////
////		Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
////
////		Vector2 firePP = new Vector2 (firePoint.position.x, firePoint.position.y);
////
////
////		GameObject spawnWave = (GameObject)Instantiate (bulletPre, new Vector3 (0, 0, 0), transform.rotation);
//
//
//
//
//	}

