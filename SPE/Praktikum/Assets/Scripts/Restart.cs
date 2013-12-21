using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
void Update () {
		if (Input.GetKeyDown ("r")) {
			Application.LoadLevel (Application.loadedLevelName);
		}
	}
}
