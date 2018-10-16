using UnityEngine;
using System.Collections;

public class ResumeGame : MonoBehaviour {
	
	public PauseMenu pauseScript;
	// Use this for initialization
	void Start () {
		pauseScript = GameObject.FindGameObjectWithTag("pauseButton").GetComponent<PauseMenu>();
	}
	
	void OnMouseDown() {
		Time.timeScale = 1;
		Transform getParent = gameObject.transform.parent;
		GameObject parent = getParent.gameObject;
		Score.stopResumGame = false;
		pauseScript.limiter = 0;
		
		DestroyObject(parent);
	}
}
