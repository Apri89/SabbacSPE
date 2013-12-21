using UnityEngine;
using System.Collections;

public class HUDsabbac : MonoBehaviour {
	private int collectables;
	private int collected;
	public GUIText goaltext;
	// Use this for initialization
	void Start () {
		collected = 0;
		collectables = 1;
		goaltext.text = "Gesammelt "+collected+" / "+collectables;

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
