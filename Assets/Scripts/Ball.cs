#pragma warning disable 0168 // variable declared but not used.
#pragma warning disable 0219 // variable assigned but not used.
#pragma warning disable 0414 // private field assigned but not used.

using UnityEngine;
using System.Collections;

//ili sus cifri za da moga da gi zema ot cikula
public enum BallType{
	Up,
	Down,
	Left,
	Right
}
public class Ball : MonoBehaviour 
{
	public BallType ballType;
	private Vector3 viewPos;
	private Score getScore;
	//public static bool outOfSight;
	//private int removeRange = 3;
	//public static bool isMoving;
	// Use this for initialization
	void Start()
	{
		//vmesto 0 ako pi6a Screen.height 6te se promeni dolu v if !!!
		viewPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 10));
		getScore = GameObject.FindWithTag("Scores").GetComponent<Score>();
		
	}
	void FixedUpdate () 
	{
		//print("ball count " + FishLogic.ballCounter.Count);
		switch(ballType) {
			
			case BallType.Up : transform.Translate(Vector3.up * Time.deltaTime*5);
			break;
			
			case BallType.Down : transform.Translate(Vector3.down * Time.deltaTime*5);
			break;
			
			case BallType.Left : transform.Translate(Vector3.left * Time.deltaTime*5);
			break;
			
			case BallType.Right : transform.Translate(Vector3.right * Time.deltaTime*5);
			break;
			
			default:;
			break;
		}
		
		
		if(transform.position.x > viewPos.x || transform.position.y < viewPos.y 
			|| -transform.position.x > viewPos.x || -transform.position.y < viewPos.y) {
		
			
			//ba4ka perf taka oba4e nqmam control vurhu vsqko edno po tozi na4in...
			//int indxOfCurrBall = LevelLogic.ballCounter.IndexOf(this.gameObject);
			//LevelLogic.ballCounter.RemoveAt(indxOfCurrBall);
			
			//po baven oba4e kontrol vurhu vseki tip topka !
			for(int i = 0; i < LevelLogic.ballCounter.Count; i++) {
				
				switch(ballType) {
			
					case BallType.Up : //print (LevelLogic.ballCounter.IndexOf(gameObject));
					LevelLogic.ballCounter.Remove(gameObject);
					break;
					
					case BallType.Down : //print (LevelLogic.ballCounter.IndexOf(gameObject));
					LevelLogic.ballCounter.Remove(gameObject);
					break;
					
					case BallType.Left : //print (LevelLogic.ballCounter.IndexOf(gameObject));
					LevelLogic.ballCounter.Remove(gameObject);
					break;
					
					case BallType.Right :// print (LevelLogic.ballCounter.IndexOf(gameObject));
					LevelLogic.ballCounter.Remove(gameObject);
					break;
					
					default:;
					break;
				}
			}
			//GameObject.Find("Player").GetComponent<Score>().scorings();
			getScore.scorings();
			//print (LevelLogic.ballCounter.IndexOf(this.gameObject));
			//print (LevelLogic.ballCounter.Count);
			//print(LevelLogic.ballCounter.Count);
			Destroy(gameObject);
			
		} 
	}
	
	//trqbva da kaja na ribata 4e e udarena !!
		void OnCollisionEnter(Collision col) {
		
			if(col.gameObject.tag == "Fish") {
				
				//ba4ka perf taka oba4e nqmam control vurhu vsqko edno po tozi na4in...
				//int indxOfCurrBall = LevelLogic.ballCounter.IndexOf(this.gameObject);
				//print(ballType);
				//LevelLogic.ballCounter.RemoveAt(indxOfCurrBall);
			
			//po baven oba4e kontrol vurhu vseki tip topka !
			for(int i = 0; i < LevelLogic.ballCounter.Count; i++) {
				
				switch(ballType) {
			
					case BallType.Up :// print (LevelLogic.ballCounter.IndexOf(gameObject));
					LevelLogic.ballCounter.Remove(gameObject);
					
					break;
					
					case BallType.Down : //print (LevelLogic.ballCounter.IndexOf(gameObject));
					LevelLogic.ballCounter.Remove(gameObject);
					break;
					
					case BallType.Left :// print (LevelLogic.ballCounter.IndexOf(gameObject));
					LevelLogic.ballCounter.Remove(gameObject);
					break;
					
					case BallType.Right :// print (LevelLogic.ballCounter.IndexOf(gameObject));
					LevelLogic.ballCounter.Remove(gameObject);
					break;
					
					default:;
					break;
				}
			}
			//GameObject.Find("Player").GetComponent<Score>().scorings();
			getScore.scorings();
		}
	}
}