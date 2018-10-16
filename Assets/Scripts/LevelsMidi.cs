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
		if(isLocked == true && PlayerPrefs.GetString("locked" + levelId , "yes") == "yes") {
			isLocked = true;
			
		} else {
			isLocked = false;
		}
		
		if(isLocked  == true) {
			gameObject.GetComponent<Renderer>().material.mainTexture = lockTexture;
		}
	}
	
	 void OnMouseDown() {
		if(isLocked == false) {
			LevelLogic.levelRawData = (int[]) (LoadXMLData.allData[levelId] as Hashtable)["rawLevel"];
			LevelLogic.maximumClicks = (int)(LoadXMLData.allData[levelId] as Hashtable)["maxClicks"];
			LevelLogic.levelId = levelId;
			
			ReloadLvl.levelIdCopy = levelId;
			Application.LoadLevel("Main");
		}
	}
	
}
