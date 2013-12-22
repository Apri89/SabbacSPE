using UnityEngine;
using System.Collections;

public class OutOfLevel : MonoBehaviour {
	private GameObject ball;
	public Transform spawnPoint;
	// Use this for initialization
	void Start () {
		ball = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter (Collider other){
		if(other.tag =="Player"){
			//Stop ballmovement
			ball.rigidbody.velocity = Vector3.zero;
			ball.rigidbody.angularVelocity = Vector3.zero;
			ball.transform.position = spawnPoint.position;
		}
	
		

	}
}
