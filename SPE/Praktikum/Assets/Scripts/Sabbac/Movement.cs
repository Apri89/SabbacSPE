using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
		private bool grounded = false;
	    public float movementSpeed = 4.0f;
		public float power = 70.0f;
		public float height;
	
	
	//FixedUpdate should be used instead of Update when dealing with Rigidbody..
	void Update () {
		Debug.DrawRay(transform.position, -Vector3.up*height, Color.green);
		RaycastHit hit;
		
		if (grounded){
	        Vector3 movement = (Input.GetAxis("Horizontal") * Vector3.right * movementSpeed)
							 + (Input.GetAxis("Vertical") * Vector3.forward * movementSpeed);			
			//Vector3 Force, ForceMode
	        rigidbody.AddForce(movement, ForceMode.Impulse);
			
			//Debug.Log("Grounded");
		
			if (Input.GetButtonDown ("Jump")){
				rigidbody.AddForce(Vector3.up * power,ForceMode.Impulse); 
			}	
		}
	}
	void OnCollisionStay(Collision collisionInfo) {
		Debug.Log("Collision: "+collisionInfo.collider.tag);
		if(collisionInfo.collider.tag == "Ground"){ 
			grounded = true;
		}
	}
	void OnCollisionExit(Collision collisionInfo) {
		if(collisionInfo.collider.tag == "Ground"){ 
			grounded = false;
		}
	}
}
