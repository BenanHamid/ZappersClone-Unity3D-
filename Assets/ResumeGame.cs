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
		//gameObject.transform.parent
		Score.stopResumGame = false;
		pauseScript.limiter = 0;
		//PauseMenu.setLimiter(0);
		//YES NAKARAH GO DA RABOTI !!!; PO TOZI NA4IN PRAVQ STATIC METOD A SAMATA PROMENLIVA SI OSTAVA
		//SKRITA, MAKAR 4E I TQ E STATIC(NO E PRIVATE !!!)
		/*int a = PauseMenu.getMoney();
		print(a);
		a += 4;
		PauseMenu.setMoney(a);
		print(a);*/
		
		DestroyObject(parent);
	}
}
