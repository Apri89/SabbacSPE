using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
		private bool grounded = false;
	    public float movementSpeed = 4.0f;
		public float power = 70.0f;
	
	
	//FixedUpdate should be used instead of Update when dealing with Rigidbody..
	void FixedUpdate () {
		//if (grounded){
	        Vector3 movement = (Input.GetAxis("Horizontal") * Vector3.right * movementSpeed)
							 + (Input.GetAxis("Vertical") * Vector3.forward * movementSpeed);			
			//Vector3 Force, ForceMode
	        rigidbody.AddForce(movement, ForceMode.Impulse);
			if (Input.GetButtonDown ("Jump") && grounded){
				rigidbody.AddForce(Vector3.up * power,ForceMode.Impulse); 
	    	}
		//}
	}
	void OnCollisionStay(Collision collisionInfo) {
		grounded = true;
	}
	void OnCollisionExit(Collision collisionInfo) {
		grounded = false;
	}
}
