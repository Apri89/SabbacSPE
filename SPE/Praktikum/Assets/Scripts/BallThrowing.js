var ball:Rigidbody;
var power:float;
var throws:int;
var txtThrows:GUIText;
var txtHighscore:GUIText;
//var splashscreen:GUITexture;
private var sessionScore:int;

function Start() {
	throws = 0;
	txtThrows.text = "Anzahl Würfe: "+throws+"\nKraft: "+power+"\nHighscore: "+PlayerPrefs.GetInt("highscore");
	//splashscreen.active=false;
	txtHighscore.active=false;
	sessionScore =0;
}

function Update() {
    if(Input.GetKeyDown ("m")){
        print("highscore reset");
   	    PlayerPrefs.DeleteKey("highscore");
   	    Application.LoadLevel (Application.loadedLevelName);
	}
	if(Input.GetKeyDown ("e")) {
    	if (DoorC.doorBroken==false) {      				
        	power = power +10;
        	throws = throws+1;
        	txtThrows.text = "Anzahl Würfe: "+throws+"\nKraft: "+power +"\nHighscore: "+PlayerPrefs.GetInt("highscore");		 
			var wurfBall = Instantiate(ball, transform.position, Quaternion.identity);
    		wurfBall.rigidbody.AddForce(transform.forward * power);  
    		
        // Door is broken.
        } else {    
        	sessionScore = throws;
        	// No Highscore exists.
        	if(!PlayerPrefs.HasKey("highscore")){
        		PlayerPrefs.SetInt("highscore",sessionScore);
        	}
        	if(PlayerPrefs.GetInt("highscore")>sessionScore){
        		PlayerPrefs.SetInt("highscore",sessionScore);		
        	} 
        	txtHighscore.active=true;
        	txtHighscore.text = "Highscore: "+PlayerPrefs.GetInt("highscore")+"\nDrücke R zum neustarten"+
        	"\n oder M um den Highscore zu reseten.";       
        	//splashscreen.active=true;
        	

        }
        
    }       
}