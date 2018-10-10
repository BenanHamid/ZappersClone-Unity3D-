using UnityEngine;
using System.Collections;

public class LoadMenu : MonoBehaviour {

	// Use this for initialization
	
	void OnMouseDown() {
		Time.timeScale = 1;
		//PauseMenu.setLimiter(0);
		Score.stopResumGame = false;
		LevelLogic.maximumClicks = 0;
		LevelLogic.fishCounter.Clear();
		LevelLogic.ballCounter.Clear();
		Application.LoadLevel("Menu");
	}
}
