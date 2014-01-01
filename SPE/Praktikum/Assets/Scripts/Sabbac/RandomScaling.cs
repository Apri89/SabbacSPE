using UnityEngine;
using System.Collections;

public class RandomScaling : MonoBehaviour {

	private bool scaleBigger = true;
	// Use this for initialization
	void Start () {
		StartCoroutine(WaitRandom());
	}
	
	// Update is called once per frame
	void Update () {
		if (scaleBigger){
			  transform.localScale += new Vector3(0.1F, 0, 0.1F);
		} else {
			transform.localScale -= new Vector3(0.1F, 0, 0.1F);
		}
	}
	
	void toggleScaling() {
		scaleBigger = !scaleBigger;
	}

	IEnumerator WaitRandom() {
		while(true){
			yield return new WaitForSeconds(2.0f);
			toggleScaling();
		}
    }
}
