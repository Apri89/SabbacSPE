using UnityEngine;
using System.Collections;

public class SoundSabbac : MonoBehaviour {

	private GameObject ball;
	private AudioClip bounceSound;

	void Start () {
		bounceSound = (AudioClip) Resources.Load("Bounce");
	}

	void Update () {
	
	}
	
	void OnCollisionEnter(Collision collisionInfo){
		if(collisionInfo.collider.tag == "Ground"){ 
			audio.PlayOneShot(bounceSound);
		}
	}
	
}
