using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
		private bool grounded = false;
	    public float movementSpeed = 4.0f;
		public float power = 50.0f;
		public float height;
		public AudioClip bounceSound;
	
	void Start(){
	}
	
	//FixedUpdate should be used instead of Update when dealing with Rigidbody..
	void FixedUpdate() {
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		
		//Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
		
	       Vector3 movement = (Input.GetAxis("Horizontal") * Vector3.right * movementSpeed)
							 + (Input.GetAxis("Vertical") * Vector3.forward * movementSpeed);			
			//Vector3 Force, ForceMode
	        rigidbody.AddForce(movement * movementSpeed * Time.deltaTime);
					
			if (Input.GetButtonDown ("Jump") && grounded){
				rigidbody.AddForce(Vector3.up * power,ForceMode.Impulse); 
			}	
	}
	
	void OnCollisionStay(Collision collisionInfo) {
		//Debug.Log("Collision: "+collisionInfo.collider.tag);
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
