using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	
	public GameObject[] menuItems;
	
	void OnMouseDown()
	{
		for(int i = 0; i < 4; i++)
		{
			GameObject levelBall1 = (GameObject)Instantiate(menuItems[0],new Vector3(i-2,i-5,0), transform.rotation);
			levelBalls rememberLevel = levelBall1.GetComponent<levelBalls>();
			rememberLevel.level = i;
		}
		Destroy(gameObject);
	}
}
