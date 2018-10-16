using UnityEngine;
using System.Collections;

public class Scrolling : MonoBehaviour {
	private float scrollSpeed = 5.2f;
	private float SPACING = 30;
	private Vector3 viewPos;
	private Vector3 mPosY;
	private Vector3 maxUpPos;
	private Vector3 maxDownPos;
	public GameObject maxUpY;

	// Use this for initialization
	void Start () {
		viewPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 9));
		maxUpPos = new Vector3(0, 0, 0);
	}
	
	void FixedUpdate () {
		mPosY.y = Input.mousePosition.y;

		if (mPosY.y < viewPos.y + SPACING) {
			transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime);
		}
		if (mPosY.y >= Screen.height - viewPos.y - SPACING) {
			transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
		}
	}
}
