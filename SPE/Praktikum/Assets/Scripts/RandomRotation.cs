using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour {
	private int speed = 100;
	private float minWait = 2.0f;
	private float maxWait = 5.0f;
	private bool forwardRotation = true;
	private float minSpeed = 150f;
	private float maxSpeed = 350f;
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
