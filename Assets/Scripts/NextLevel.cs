﻿using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {
	void OnMouseDown() {
		Time.timeScale = 1;
		Score.stopResumGame = false;
		LevelLogic.maximumClicks = 0;
		LevelLogic.fishCounter.Clear();
		LevelLogic.ballCounter.Clear();
		
		string currLvlId = LevelLogic.levelId;
		int nextLvlIndex = LoadXMLData.idNumbers.IndexOf(ReloadLvl.levelIdCopy) + 1;
		string nextLvlId = LoadXMLData.idNumbers[nextLvlIndex];
		ReloadLvl.levelIdCopy = nextLvlId;
		
		LevelLogic.levelRawData = (int[]) (LoadXMLData.allData[nextLvlId] as Hashtable)["rawLevel"];
		LevelLogic.maximumClicks = (int)(LoadXMLData.allData[nextLvlId] as Hashtable)["maxClicks"];
		
		Application.LoadLevel("Main");
	}
}
