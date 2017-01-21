using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody2D myRigidbody;
	public float moveSpeed = 10f;
	public bool hasKnife;




	void Start () {
		myRigidbody = gameObject.GetComponent <Rigidbody2D> ();
        this.name = "Player";
	}



	void Update () {

		//Move left
		if(Input.GetKey(KeyCode.LeftArrow)){
			Vector2 leftVector = new Vector2 ();
			leftVector.x = -moveSpeed;

			myRigidbody.AddForce (leftVector);
		}

		//Move right
		if(Input.GetKey(KeyCode.RightArrow)){
			Vector2 rightVector = new Vector2 ();
			rightVector.x = moveSpeed;

			myRigidbody.AddForce (rightVector);
		}

		//Move up
		if(Input.GetKey(KeyCode.UpArrow)){
			Vector2 upVector = new Vector2 ();
			upVector.y = moveSpeed;

			myRigidbody.AddForce (upVector);
		}

		//Move down
		if(Input.GetKey(KeyCode.DownArrow)){
			Vector2 downVector = new Vector2 ();
			downVector.y = -moveSpeed;

			myRigidbody.AddForce (downVector);
		}

	
}
	//Pick up objects

//	void OnCollisionEnter2D (Collision2D other){
		//Collect Knife
//		if (other.gameObject.tag == "Knife") {
//			hasKnife = true;
//		}

	    //Kill Person
//		if (other.gameObject.tag == "Person" && hasKnife == true) {
//		Destroy (other.gameObject);
//		hasKnife = false;
//		}


//	}
}		
			