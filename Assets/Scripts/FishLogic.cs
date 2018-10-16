#pragma warning disable 0168 // variable declared but not used.
#pragma warning disable 0219 // variable assigned but not used.
#pragma warning disable 0414 // private field assigned but not used.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

public class FishLogic : MonoBehaviour 
{
	public GameObject ball;
	public Score tester;
	Score test;
	public Material[] fishMaterials = new Material [3];
	public int level;
	private Score getScore;
	//public static int maximumClicks;
	//public static string levelId;
	
	//public static List<GameObject> ballCounter = new List<GameObject>();
	
	
	void Start () {
		//tester = GameObject.Find("Player").GetComponent<Score>();
		//test = (Score)tester.GetComponent(typeof(Score));
	}
	
	void OnMouseDown() {
		
		if(LevelLogic.maximumClicks <= 0) {
			return;
		}
		LevelLogic.maximumClicks--;
		updateFish();

		GameObject.FindWithTag("Scores").GetComponent<Score>().scorings();
	}
	
	void updateFish() {
		if(level == 1) {
			//clicked = true;
			for(int i = 0; i < 4; i++) {
				Ball ballDirection = ball.GetComponent<Ball>();
				
				if(i == 0)
				{
					ballDirection.ballType = BallType.Up;
				}
				if(i == 1)
				{
					ballDirection.ballType = BallType.Down;
				}
				if(i == 2)
				{
					ballDirection.ballType = BallType.Left;	
				}
				if(i == 3)
				{
					ballDirection.ballType = BallType.Right;	
				}
				
				GameObject ballClone = (GameObject)Instantiate(ball, transform.position, Quaternion.LookRotation(Vector3.forward));
				LevelLogic.ballCounter.Add(ballClone);
			}
			
			LevelLogic.fishCounter.Remove(this.gameObject);
			Destroy(gameObject);
		} else {
			setLevel(level--);
		}
	}
	public void setLevel(int lvl) {
		lvl = level;
		gameObject.GetComponent<Renderer>().material = fishMaterials[lvl-1];
		transform.localScale = new Vector3(1, transform.localScale.y + lvl*0.06f, 1);
	}
	
	void OnCollisionEnter(Collision col) {
		updateFish();
		Destroy(col.gameObject);
	}
}
