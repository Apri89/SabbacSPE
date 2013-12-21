using UnityEngine;
using System.Collections;

public class DoorAni : MonoBehaviour {
	public AudioClip clip1;
	public AudioClip clip2;
	
	void OnTriggerEnter (Collider other) {	
		animation["doorOpenUnity"].speed = 2F;
		audio.clip = clip1;
		audio.Play();
		animation.Play();
	}
	void OnTriggerExit(Collider other){
		animation["doorOpenUnity"].normalizedTime = 1F;
		animation["doorOpenUnity"].speed = -3F;
		audio.clip = clip2;
		audio.Play();
		animation.Play();
	}
}

