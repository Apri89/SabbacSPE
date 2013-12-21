using UnityEngine;
using System.Collections;

public class Sound : MonoBehaviour {
	public AudioClip clip1;
	public AudioClip clip2;
	public AudioClip clip3;
	public GUIText txt;
	void Start () {
		txt.text ="SoundFx\n\nDrücke 1-3 um die Sounddatei zu ändern." +
			"\nPlay: q \nLoop: w \nMute: e \nPlayOneShot: r \nStop: s \nPause: p" +
			"\nLautstärke+: . \nLautstärke-: -";
	}
	void Update () {
		if (Input.GetKeyDown ("1")) {
			print ("Set Audioclip to clip1");
			audio.clip = clip1;
			audio.Play();
		}
		if (Input.GetKeyDown ("2")) {
			print ("Set Audioclip to clip2");
			audio.clip = clip2;
			audio.Play();
		}
		if (Input.GetKeyDown ("3")) {
			print ("Set Audioclip to clip3");
			audio.clip = clip3;
			audio.Play();
		}
		if (Input.GetKeyDown ("q")) {		
			print ("Audio play");
			if(!audio.isPlaying){
				audio.Play();				
			}	
			
		}
		if (Input.GetKeyDown ("w")) {
			print ("Audio loop");
			audio.Play();
			audio.loop = true;
		}
		if (Input.GetKeyDown ("e")) {
			if(audio.mute){
				print ("Audio mute off");
				audio.mute = false;
			} else {
				print ("Audio mute on");
				audio.mute = true;
			}
		}
		if (Input.GetKeyDown ("r")) {
			print ("PlayOneShot");
			audio.PlayOneShot(audio.clip);
		}
		if (Input.GetKeyDown ("s")) {
			print ("Audio stop");
			audio.Stop();
		}
		if (Input.GetKeyDown ("p")) {
			print ("Audio pause");
			audio.Pause();
		}
		if (Input.GetKeyDown ("-")) {		
			audio.volume -= Time.deltaTime * 1.5F;
			print ("Decrease Volume " +audio.volume);		
		}
		if (Input.GetKeyDown (".")) {		
			audio.volume += Time.deltaTime * 1.5F;
			print ("Increase Volume " +audio.volume);			
		}
	}
}
