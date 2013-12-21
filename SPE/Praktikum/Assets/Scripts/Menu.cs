using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {
	
	public AudioClip clickClip;
	private Rect button;
	private float buttonWidth = 360;
	private float buttonlHeight = 30;
	private float space = 20;
	
	void Start () {
		audio.clip = clickClip;
	}
	void Awake () {
		button = new Rect((Screen.width - buttonWidth)/2,0,buttonWidth,buttonlHeight);	
	}
	void OnGUI() {
		    //background box
			GUI.Box(new Rect(((Screen.width - buttonWidth)/2)-20,space*2,400,230), "SPE Praktikum 2013");
			// Centered
			button.y = buttonlHeight+space*2; 
			if (GUI.Button (button, "Lade Aufgabe1 (SoundFX)")){		
				audio.Play();
				Application.LoadLevel("SoundFX");		
			}
			button.y += buttonlHeight + space; 
			if (GUI.Button (button,"Lade Aufgabe 2-3 (Door, HUD)")){
				audio.Play();
				Application.LoadLevel("TheDoor");
				
			}
			button.y += buttonlHeight + space; 
			if (GUI.Button (button,"Lade Aufgabe5")){
				audio.Play();
				Application.LoadLevel("Sabbac");
			}
			button.y += buttonlHeight + space; 
			if (GUI.Button (button,"Beenden")){
				audio.Play();
				Application.Quit();
			}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
