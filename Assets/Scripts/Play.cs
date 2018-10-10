using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	
	public GameObject[] menuItems;
	/*Vector3 viewPos;
	// Use this for initialization
	void Start () {
		
		viewPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 10));
	}*/
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown()
	{
		for(int i = 0; i < 4; i++)
		{
			GameObject levelBall1 = (GameObject)Instantiate(menuItems[0],new Vector3(i-2,i-5,0), transform.rotation);
			levelBalls rememberLevel = levelBall1.GetComponent<levelBalls>();
			rememberLevel.level = i;
			/*if(i == 0)
			{
				GameObject levelBall = (GameObject)Instantiate(menuItems[0],new Vector3(i+2,i-5,0), transform.rotation);
			}
			if(i == 1)
			{
				GameObject levelBall = (GameObject)Instantiate(menuItems[0],new Vector3(i-3,i-3,0), transform.rotation);
			}
			if(i == 2)
			{
				GameObject levelBall = (GameObject)Instantiate(menuItems[0],new Vector3(i,i-3,0), transform.rotation);
			}
			if(i == 3)
			{
				GameObject levelBall = (GameObject)Instantiate(menuItems[0],new Vector3(i-4,i-1,0), transform.rotation);
			}*/
		}
		Destroy(gameObject);
	}
}
