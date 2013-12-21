using UnityEngine;
using System.Collections;

public class RandomRotation : MonoBehaviour {
	private int mode = 0; 
	private int speed = 100;
	private int min = 3;
	private int max = 8;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		// Für Testzwecke!!! Eigentlich zufällige Änderung nach zufälliger Zeit aber min 3 sek max 8 sek.!
		if (Input.GetKeyDown ("1")) {
			mode = 0;
		}
		if (Input.GetKeyDown ("2")) {
			mode = 1;
		}
		
		
		if (mode == 0){
		transform.Rotate(Vector3.forward * Time.deltaTime * speed);
		} else {
		transform.Rotate(-Vector3.forward * Time.deltaTime * (speed-20));
		}
	}
}
