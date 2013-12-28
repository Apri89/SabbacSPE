using UnityEngine;
using System.Collections;

public class MoveUpDown : MonoBehaviour {
	private float minWait = 2.0f;
	private float maxWait = 5.0f;

	private float minSpeed = 150f;
	private float maxSpeed = 250f;
	private bool forwardRotation = true;
	// Use this for initialization
	void Start () {
		StartCoroutine(WaitRandom());
	}
	
	// Update is called once per frame
	void Update () {
		if (forwardRotation){
			  transform.Translate(Vector3.up * Time.deltaTime*5.0f);
		} else {
			transform.Translate(-Vector3.up * Time.deltaTime*5.0f);
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