using UnityEngine;
using System.Collections;

public class LoadMenu : MonoBehaviour {
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
