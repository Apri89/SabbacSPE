using UnityEngine;
using System.Collections;

public class HitCube : MonoBehaviour {
	private GameObject ball;
	public Transform spawnPoint;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision){
		Vector3 contact = collision.contacts[0].point;
		
	    Vector3 relativePosition = transform.InverseTransformPoint(contact);
	
	    if (relativePosition.y > 0) {
	
	    	Debug.Log("The object is to the above");
	
	    } else {
	
	    	Debug.Log("The object is to the under");
			ball.rigidbody.velocity = Vector3.zero;
			ball.rigidbody.angularVelocity = Vector3.zero;
			ball.transform.position = spawnPoint.position;
	    }

	}
}

