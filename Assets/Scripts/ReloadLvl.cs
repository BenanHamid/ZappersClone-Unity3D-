using UnityEngine;
using System.Collections;

public class ReloadLvl : MonoBehaviour {
	
	//static public int[] lvlDataCopy;
	//static public int maxClicksCopy;
	public static string levelIdCopy;
	
	void Start() {
		
	}
	void OnMouseDown() {
		
		//trqbva da se opravi razmera na masiva pri zarejdaneto; ne znam za6to se udvoqva...
		//initIdNumbSize = LoadXMLData.idNumbers.Count;
		
		//LevelLogic.fishCounter = 0;
		//LevelLogic.levelRawData = lvlDataCopy;
		//FishLogic.maximumClicks = maxClicksCopy;
		Score.stopResumGame = false;
		//PauseMenu.setLimiter(0);
		Time.timeScale = 1;
		LevelLogic.maximumClicks = 0;
		LevelLogic.fishCounter.Clear();
		LevelLogic.ballCounter.Clear();
		LevelLogic.levelRawData = (int[]) (LoadXMLData.allData[levelIdCopy] as Hashtable)["rawLevel"];
		LevelLogic.maximumClicks = (int)(LoadXMLData.allData[levelIdCopy] as Hashtable)["maxClicks"];
		
		Application.LoadLevel("Main");
	}
}
