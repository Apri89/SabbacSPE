using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour {
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
			transform.Rotate(Vector3.forward * Time.deltaTime * Random.Range(minSpeed, maxSpeed));
		} else {
			transform.Rotate(-Vector3.forward * Time.deltaTime * Random.Range(minSpeed, maxSpeed));
		}
	}
	
	void toggleRotation() {
		forwardRotation = !forwardRotation;
	}
	
	IEnumerator WaitRandom() {
		while(true){
			yield return new WaitForSeconds(Random.Range(minWait, maxWait));
			toggleRotation();
		}
    }
}
