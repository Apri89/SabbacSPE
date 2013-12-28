using UnityEngine;
using System.Collections;

public class RandomTranslationZ : MonoBehaviour {
	// Seconds
	private bool forwardRotation = true;
	
	void Start () {
		StartCoroutine(WaitRandom());
	}
	
	void Update () {
		if (forwardRotation){
			  transform.Translate(Vector3.up * 5 * Time.deltaTime);
		} else {
			transform.Translate(-Vector3.up * 5 * Time.deltaTime);
		}
	}
	
	void toggleRotation() {
		forwardRotation = !forwardRotation;
	}

	IEnumerator WaitRandom() {
		while(true){
			yield return new WaitForSeconds(1.0f);
			toggleRotation();
		}
    }
}
