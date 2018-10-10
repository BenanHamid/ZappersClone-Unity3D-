using UnityEngine;
using System.Collections;

public class levelBalls : MonoBehaviour {
	
	public int level;
	public GameObject midi;
	GameObject[] levelBall;
	// Use this for initialization
	void Start () {
		levelBall = GameObject.FindGameObjectsWithTag("LevelBall");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown()
	{
		if(level == 1)
		{
			for(int i = 0; i < 50; i++) {
				int x = i/5;
				int y = i%5;
				Instantiate(midi, new Vector3(y-2,x-4.5f , 0), transform.rotation);
				//assign levels to each
			}
			
			Destroy(gameObject);
			for(int i = 0; i < levelBall.Length; i++){
				
				Destroy(levelBall[i]);
			}
			
		} else if(level == 2)
		{
			for(int i = 0; i < 60; i++) {
				int x = i/5;
				int y = i%5;
				Instantiate(midi, new Vector3(y-2,x-4.5f , 0), transform.rotation);
			}
			Destroy(gameObject);
			
			for(int i = 0; i < levelBall.Length; i++){
				
				Destroy(levelBall[i]);
			}
			
		} else if(level == 3)
		{
			for(int i = 0; i < 60; i++) {
				int x = i/5;
				int y = i%5;
				Instantiate(midi, new Vector3(y-2,x-4.5f , 0), transform.rotation);
			}
			
			Destroy(gameObject);
			
			for(int i = 0; i < levelBall.Length; i++){
				
				Destroy(levelBall[i]);
			}
			
		} else if(level == 4)
		{
			for(int i = 0; i < 60; i++) {
				int x = i/5;
				int y = i%5;
				Instantiate(midi, new Vector3(y-2,x-4.5f , 0), transform.rotation);
			}
			
			Destroy(gameObject);
			
			for(int i = 0; i < levelBall.Length; i++){
				
				Destroy(levelBall[i]);
			}
		}
	}
		
}
