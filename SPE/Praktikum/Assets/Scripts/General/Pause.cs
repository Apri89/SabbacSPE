using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public AudioClip clickClip;
	public static bool isPaused = false;
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
		if(isPaused){
			// Centered
			button.y = (Screen.height - buttonlHeight)/2;
			if (GUI.Button (button,"Fortsetzen")){
				audio.Play();
				PauseGame();
			}
			button.y += buttonlHeight + space; 
			if (GUI.Button (button,"Zum Hauptmenü")){
				audio.Play();
				PauseGame();
				Application.LoadLevel(0);
				
			}
			button.y += buttonlHeight + space; 
			if (GUI.Button (button,"Beenden")){
				audio.Play();
				Application.Quit();
			}
		}
	}
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)) {
			PauseGame();
		}	
	}
	void PauseGame() {
		if(!isPaused) {
			Time.timeScale = 0;
		} else {
			Time.timeScale = 1;
		}
		isPaused = !isPaused;
	}
}
