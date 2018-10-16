using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	private RaycastHit hit;
	private Ray ray;
	public GameObject pauseScreen;
	public int limiter = 0;
	
	void OnMouseDown() {
		limiter++;
		if(limiter == 1 && Score.stopResumGame == false) {
			GameObject pauseMenu = (GameObject)Instantiate(pauseScreen,new Vector3(0, 0, -1), Quaternion.identity);
			Time.timeScale = 0;
		}
	}
}
