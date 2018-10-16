using UnityEngine;
using System.Collections;

public class ReloadLvl : MonoBehaviour {
	public static string levelIdCopy;

	void OnMouseDown() {
		Score.stopResumGame = false;
		Time.timeScale = 1;
		LevelLogic.maximumClicks = 0;
		LevelLogic.fishCounter.Clear();
		LevelLogic.ballCounter.Clear();
		
		LevelLogic.levelRawData = (int[]) (LoadXMLData.allData[levelIdCopy] as Hashtable)["rawLevel"];
		LevelLogic.maximumClicks = (int)(LoadXMLData.allData[levelIdCopy] as Hashtable)["maxClicks"];
		
		Application.LoadLevel("Main");
	}
}
