using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {
	// 
	private int score;
	private int coins;
	private GameObject[] gos;
	public GUIText goaltext;
	public GUIText timetext;
	public GameObject insZieltxt;
	public GameObject einsammelntxt;
	private GameObject goal;
	private Time highscoreTime;

	void Start () {
		insZieltxt.SetActive(false);
		goal = GameObject.FindWithTag("Finish");
		// How many Coins are in the level?
        gos = GameObject.FindGameObjectsWithTag("Coin"); 
		coins = gos.Length;
		score = 0;	
		// Set text of the HUD
		goaltext.text = "Gesammelt "+score+" / "+coins;
		timetext.text =  Time.timeSinceLevelLoad.ToString() +" | 3.29";
	}
	void Update () {
		goaltext.text = "Gesammelt "+score+" / "+coins;
		// f2: 2 Decimals
		timetext.text =  Time.timeSinceLevelLoad.ToString("f2") +" | 3.29";
		if(everytingCollected()){
			goal.renderer.material.color = Color.green;
			Destroy(einsammelntxt);
			insZieltxt.GetComponent<TextMesh>().text = "ins Ziel";
			insZieltxt.SetActive(true);
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
				Application.LoadLevel("SabbacProto");
			} else {
				insZieltxt.SetActive(true);
				insZieltxt.GetComponent<TextMesh>().text = "Nicht alles gesammelt!";
				//insZieltxt.GetComponent(TextMesh).text = "blah";
			}
    	}
	}
}
