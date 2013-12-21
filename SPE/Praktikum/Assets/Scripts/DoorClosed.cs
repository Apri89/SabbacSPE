using UnityEngine;
using System.Collections;

public class DoorClosed : MonoBehaviour {
	//static bool isBroken = false;
	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnJointBreak(float breakForce) {
        print ("Tür kaputt!");
		//isBroken = true;
    }
}
