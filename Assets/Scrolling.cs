using UnityEngine;
using System.Collections;

public class Scrolling : MonoBehaviour {
	
	//private int scrollArea = 5;
	private float scrollSpeed = 5.2f;
	private float SPACING = 30;
	private Vector3 viewPos;
	//private Vector3 mPosX;
	private Vector3 mPosY;
	private Vector3 maxUpPos;
	private Vector3 maxDownPos;
	public GameObject maxUpY;
	// Use this for initialization
	void Start () {
		viewPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 9));
		//maximalnata poziciq trqbva da se markira s nqkakuv empty game object(spored men)
		maxUpPos = new Vector3(0, 0, 0);
		
		//maxDownPos.y = -mPosY.y;
	}
	
	// ne mislq 4e moga da izbegna coroutine ili update tuk za6toto 
	// moje po vsqko vreme da dam da se skrollne !
	
	// ZA da ograni4a skrolinga trqbva pri start da vzema poziciqta na purviq i posledniq element
	// kato tqh 6te gi namiram ot drugite klasove(ot masivi ot xml-a ili ot drugo)
	// i 6te zadam kato uslovie v update-a 
	//while(!kraq || !na4aloto) { skrolvai ! }
	void FixedUpdate () {
		//viewPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width - SPACING, Screen.height - SPACING, 9));

		//mPosX.x = Input.mousePosition.x;
		mPosY.y = Input.mousePosition.y;
		//print(mPosY.y);
		 
		// Do camera movement by mouse position
		/*if (mPosX.x < viewPos.x) {
			transform.Translate(Vector3.right * - scrollSpeed * Time.deltaTime);
		}*/
		/*if (mPosX.x >= Screen.width - viewPos.x) {
			transform.Translate(Vector3.right * scrollSpeed * Time.deltaTime);
		}*/
		//if(maxUpY.transform.position.y > mPosY.y) {
			//za murdane nadolu
			if (mPosY.y < viewPos.y + SPACING) {
				transform.Translate(Vector3.down * scrollSpeed * Time.deltaTime);
			}
			//za murdane nagore
			if (mPosY.y >= Screen.height - viewPos.y - SPACING) {
				transform.Translate(Vector3.up * scrollSpeed * Time.deltaTime);
			}
		//}
		
		//works lol
		/*if ( (Input.GetKey("left alt") || Input.GetKey("right alt")) || Input.GetMouseButton(2) ) {
			gameObject.transform.Translate(new Vector3(Input.GetAxis("Mouse X")*scrollSpeed, Input.GetAxis("Mouse Y")*scrollSpeed, 0));
		}*/
	
	}
}
