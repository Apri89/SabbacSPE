using UnityEngine;
using System.Collections;

public class RandomTranslationX : MonoBehaviour {
	// Seconds
	private float minWait = 2.0f;
	private float maxWait = 5.0f;
	
	private float minSpeed = 150f;
	private float maxSpeed = 350f;
	private bool forwardRotation = true;
	
	void Start () {
		StartCoroutine(WaitRandom());
	}
	
	void Update () {
		if (forwardRotation){
			  transform.Translate(Vector3.right * Time.deltaTime*10.0f);
		} else {
			transform.Translate(-Vector3.right * Time.deltaTime*10.0f);
		}
	}
	
	void toggleRotation() {
		forwardRotation = !forwardRotation;
	}
	
	IEnumerator WaitRandom() {
		while(true){
			yield return new WaitForSeconds(2.0f);
			toggleRotation();
		}
    }
}
