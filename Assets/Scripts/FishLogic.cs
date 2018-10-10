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
	
	// Update is called once per frame
	void Update () {
		
		//print("max clicks " + LevelLogic.maximumClicks);
		//print("fish counter " + LevelLogic.fishCounter.Count);
		//print ("clicked " + clicked);
	}
	
	
	//if nqkakuv bool = true da se izpulni dokato ne se izpulni 
	//nqkakuv broq4 (nova promenliva) posle stava false
	
	//ne se polzva mousedown
	//polzva se input i raycast i collider-i i tagove i tnt specialno za touch ustroistva !!!
	//
	
	void OnMouseDown() {
		
		if(LevelLogic.maximumClicks <= 0) {
			return;
		}
		LevelLogic.maximumClicks--;
		updateFish();
		//moga s sendmessage da napravq maxclicks izpra6taneto...
		
		//trqbva da go vikam v nqkakuv drug obekt koito nqma da iz4ezne oba4e pak bez update...
		//kak da staneeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeeee ?
		//GameObject.Find("Player").GetComponent<Score>().scorings();
		GameObject.FindWithTag("Scores").GetComponent<Score>().scorings();
	}
	
	void updateFish() {
		
		if(level == 1) {
		
			//clicked = true;
			for(int i = 0; i < 4; i++) {
				
				//samiq obekt da da dobavq v masiv ot obekti
				//purvo go vzemam ot orignalnoto za da mu set-na posokite !
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
				//print(ballClone);
				LevelLogic.ballCounter.Add(ballClone);
				//print(LevelLogic.ballCounter.IndexOf(ballClone));
				//print (ballDirection.ballType);
				//print(ballDirection.ballType);
				/*if(LevelLogic.fishCounter.Count == 2) {
					ballCounter.Add(i);
				}*/
				//BallLeft ballDirection = bubblesClone1.GetComponent<BallLeft>();
			
			}
			//removedFish = true;
			
			//ne znam dali trqbvda se uto4ni to4no koq riba da maham ?
			LevelLogic.fishCounter.Remove(this.gameObject);
			
			//tova uto4nqva to4no koq riba da se maha !
			//mn rqdko throwa exception !
			//int indxOfCurrFish = LevelLogic.fishCounter.IndexOf(this.gameObject);
			//LevelLogic.fishCounter.RemoveAt(indxOfCurrFish);
			Destroy(gameObject);
			
				
		} else {
			
			setLevel(level--);
			//removedFish = false;
			//clicked = false;
		}
		//print(LevelLogic.ballCounter.Count);
		
	}
	public void setLevel(int lvl) {
		
		//za6to mi trqbva lvl=level nali go polu4avam kato parametur ????
		//lvl = level + 1;
		lvl = level;
		gameObject.GetComponent<Renderer>().material = fishMaterials[lvl-1];
		//vmesto scale 6te gi zamestvam s drugi gameObject
		transform.localScale = new Vector3(1, transform.localScale.y + lvl*0.06f, 1);
	}
	
	void OnCollisionEnter(Collision col) {
	
		//maximumClicks++;
		updateFish();
		//print("hit by ball");
		Destroy(col.gameObject);
	}
	
}
