using UnityEngine;
using System.Collections;

public class PauseMenu : MonoBehaviour {
	private RaycastHit hit;
	private Ray ray;
	public GameObject pauseScreen;
	public int limiter = 0;
	
	// Use this for initialization
	void Start () {
		//ray = Camera.main.ScreenPointToRay(Input.mousePosition);
	 	
	}
	
	/*public static void setLimiter(int i) {
		limiter = i;
	}
	
	public static int getLimiter() {
		return limiter;
	}*/
	/*void Update () {
	  // sus touch taka mislq 4e 6e stane no nqma kak da probvam....
		if(Input.GetMouseButtonDown(0)) {
			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if(Physics.Raycast(ray, out hit, 20)) {
				print(hit.collider.tag);
				if(hit.collider.tag == "pauseButton") {
					GameObject pauseMenu = (GameObject)Instantiate(pauseScreen,new Vector3(0, 0, -1), Quaternion.identity);
					//return;
				}
			}
		}
	}*/
	
	void OnMouseDown() {
		limiter++;
		if(limiter == 1 && Score.stopResumGame == false) {
			GameObject pauseMenu = (GameObject)Instantiate(pauseScreen,new Vector3(0, 0, -1), Quaternion.identity);
			Time.timeScale = 0;
			//return;
		}
		
		//limiter = 0;
		
	}
}
