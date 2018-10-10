using UnityEngine;
using System.Collections;

public class LevelsMidi : MonoBehaviour {
	
	//public int level;
	//public string lockedLvl;
	public string levelId;
	public Texture lockTexture;
	private bool isLocked;
	
	void Start() {
		
		isLocked = (bool)(LoadXMLData.allData[levelId] as Hashtable)["locked"];
		//print(isLocked);
		if(isLocked == true && PlayerPrefs.GetString("locked" + levelId , "yes") == "yes") {
			
			isLocked = true;
			
		} else {
			
			isLocked = false;
		}
		
		//tuka trqbva pove4e da se buta pove4e za locked unlocked !!!!
		if(isLocked  == true) {
			gameObject.GetComponent<Renderer>().material.mainTexture = lockTexture;
		}
		//PlayerPrefs.Save();
		
	}
	
	 void OnMouseDown() {
		//print(isLocked + " is locked");
		//moga da podam i na tqh id i ot tehnite klasove 
		//print(locked);
		//sendmessage za nivoto ili ne ?
		//TextMesh gettest = transform.GetComponentInChildren<TextMesh>();
		//SendMessage("setLevel", gettest.text);
		if(isLocked == false) {
			LevelLogic.levelRawData = (int[]) (LoadXMLData.allData[levelId] as Hashtable)["rawLevel"];
			LevelLogic.maximumClicks = (int)(LoadXMLData.allData[levelId] as Hashtable)["maxClicks"];
			LevelLogic.levelId = levelId;
			
			ReloadLvl.levelIdCopy = levelId;
			//ReloadLvl.lvlDataCopy = lvlData;
			//ReloadLvl.maxClicksCopy = maxClicks;
			
			//print(maxClicks);
			//print (LoadXMLData.lvlLocks[0]);
			Application.LoadLevel("Main");
		}
	}
	
}
