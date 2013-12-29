using UnityEngine;
using System.Collections;

public class CoinCollect : MonoBehaviour {
	// 
	private int score;
	private int coins;
	private GameObject[] gos;
	public GUIText goaltext;
	public GUIText timetext;
	private GameObject goal;
	private Time highscoreTime;
	private AudioClip winSound, collectSound;
	
	void Start () {
		goal = GameObject.FindWithTag("Finish");
		// How many Coins are in the level?
        gos = GameObject.FindGameObjectsWithTag("Coin"); 
		coins = gos.Length;
		score = 0;	
		// Set text of the HUD
		goaltext.text = "Gesammelt "+score+" / "+coins;
		timetext.text =  Time.timeSinceLevelLoad.ToString() +" | 3.29";
		//goal.renderer.material.color = Color.red;			
		winSound = (AudioClip) Resources.Load("richtig");
		collectSound = (AudioClip) Resources.Load("falsch");
	}
	void Update () {
		goaltext.text = "Gesammelt "+score+" / "+coins;
		// f2: 2 Decimals
		timetext.text =  Time.timeSinceLevelLoad.ToString("f2") +" | 3.29";
		if(everytingCollected()){
			print ("Alles eingesammelt. Ab ins Ziel!");
			goal.renderer.material.color = Color.green;
		}	
	}
	// Checks if everything is collected
	bool everytingCollected(){
		return coins == score;
	}	
	
	void OnTriggerEnter (Collider other){
		// Collecting Coin:
		if (other.tag == "Coin") {
        	score ++;
        	Destroy(other.gameObject);
    	}
		
		if (other.tag == "Finish") {
			if (everytingCollected()){
				audio.PlayOneShot(winSound);
				StartCoroutine(WaitAndLoadLevel()); 		
			} else {
				audio.PlayOneShot(collectSound);
				print("Noch nicht alles eingesammelt!");				
			}
    	}
	}
	
	IEnumerator WaitAndLoadLevel() {
        yield return new WaitForSeconds(1);
		Application.LoadLevel (Application.loadedLevelName);
    }
}
