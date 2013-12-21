using UnityEngine;
using System.Collections;

public class Menu1 : MonoBehaviour {
	private string menu;
	private int buttonWidth = 250;
	private bool toggleB = false;
	public AudioClip clickClip;
	
	void Start () {
		//width = 300;
		menu ="main";
		audio.clip = clickClip;
	}
	void OnGUI () {
		//GUILayout.BeginVertical("box",GUILayout.Width(buttonWidth));
		GUILayout.BeginArea (new Rect(((Screen.width - buttonWidth)/2),Screen.width/9,buttonWidth,buttonWidth));
		// MainMenuView
		if(menu.Equals("main")){			
			if (GUILayout.Button("Aufgabe 1 (SoundFX)")){									
				audio.Play();
				Application.LoadLevel("SoundFX");		
			}
			if (GUILayout.Button("Aufgabe 2-3 (Door, HUD)")){					
				audio.Play();
				Application.LoadLevel("TheDoor");		
			}
			if (GUILayout.Button("Aufgabe 5 (Sabbac)")){
				audio.Play();
				Application.LoadLevel("Sabbac");
			}
			if (GUILayout.Button("Optionen")){					
				menu = "options";
				audio.Play();	
			}
			if (GUILayout.Button("Beenden")){
				audio.Play();
				Application.Quit();
			}
		// OptionView	
		} else if (menu.Equals("options")){
			if (GUILayout.Button("Einstellung A")){									
				audio.Play();	
			}
			toggleB = GUILayout.Toggle(toggleB,"Einstellung B");
		
			if (GUILayout.Button("Einstellung C")){
				audio.Play();
			}
			if (GUILayout.Button("zurück")){									
				audio.Play();
				menu = "main";		
			}
		}
		GUILayout.EndArea ();
		//GUILayout.EndVertical();
	}
	
	// Update is called once per frame
	void Update () {	
	}

}
