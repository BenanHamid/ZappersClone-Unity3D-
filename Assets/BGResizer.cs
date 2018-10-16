using UnityEngine;
using System.Collections;

public class BGResizer : MonoBehaviour {
	
	private Vector3 viewPos;
	private float MULTIPLY = 2F;

	void Start () {
		viewPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 11.1f));
		transform.localScale = new Vector3(viewPos.x*MULTIPLY, viewPos.y*MULTIPLY, 0);
	}
}
