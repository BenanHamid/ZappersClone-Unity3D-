#pragma warning disable 0168 // variable declared but not used.
#pragma warning disable 0219 // variable assigned but not used.
#pragma warning disable 0414 // private field assigned but not used.

using UnityEngine;
using System.Collections;

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

	void Start()
	{
		viewPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 10));
		getScore = GameObject.FindWithTag("Scores").GetComponent<Score>();
		
	}
	void FixedUpdate () 
	{
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
			getScore.scorings();

			Destroy(gameObject);
		} 
	}
	
	void OnCollisionEnter(Collision col) {
		if(col.gameObject.tag == "Fish") {
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
			
			getScore.scorings();
		}
	}
}