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

public class LevelLogic : MonoBehaviour {
	
	public GameObject ballPrefab;
	//tuka opredelqm kude 6te sa figurite; vmesto da pi6a razmer na masiva pi6a
	//cifri i tam deto e 0 6te e prazno
	//levelRawData = {1-gore vlqvo, 0,0,0,0,0,0,0,0,1..}
	//private int[] levelRawData = new int[30];
	
	//1 - dolniq lqv ugul; 5 goren lqv ugul; vsqko kratno na 5 e gore
	//private int[] levelRawData2 = {/*1*/1,0,0,0,/*5*/2,0,0,0,0,/*10*/1,0,0,0,0,/*15*/2,0,0,0,0,/*20*/3,0,0,0,0,/*25*/0,0,0,0,0,/*30*/4};
	//error
	static public int[] levelRawData;
	public Material[] fishMaterials = new Material[4];
	public static List<GameObject> fishCounter  = new List<GameObject>();
	public static int lvlTime;
	private float SPACING = 0.3F;
	//levelId i maxClicks trq da sa tuka spored men za6toto tozi klas se griji kato cqlo za nivata i suzdava ribite !
	public static string levelId;
	public static int maximumClicks;
	//samo za ball counter ne sum sig 4e trqbva da e tuka
	public static List<GameObject> ballCounter = new List<GameObject>();
	public GameObject[] buttons = new GameObject[4];
	//Vector3 viewPort;
	
	//void FixedUpdate() {
		//needs to be fixed !!!
		//lvlTime = (int)Time.timeSinceLevelLoad;
		//print (lvlTime);
		//print(lvlTime);
	//}
	void Start() {
		
		//viewPort = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, 0, 10));
		InvokeRepeating("levelTime", 0, 1);
		CreateGrid();
	}
	
	void CreateGrid() {
		
		//tuka za vremeto
		//print (maximumClicks);
		
		for(int i = 0; i < levelRawData.Length; i++) {
			int x = i/5;
			int y = i%5;
			//levelRawData[i] = Random.Range(0, 5);
			//print (x + " " + y + " - " + levelRawData[i]);
			
			//ballPrefab get script setlevel -> set scale 
			//Instantiate();
			//broq gi kato suzdavam i gi namalqvam kato uni6tojavam 
			if(levelRawData[i] != 0) {
				
				GameObject ballPrefabClone = (GameObject)Instantiate(ballPrefab, new Vector3(x-2.5f, y-3, 0), transform.rotation);
				//fishCounter.Add(levelRawData[i]);
				fishCounter.Add(ballPrefabClone);
				//print(fishCounter[i] + " FishCounter");
				FishLogic rememberLevel =  ballPrefabClone.GetComponent<FishLogic>();
				rememberLevel.level = levelRawData[i];
				ballPrefabClone.gameObject.transform.localScale = new Vector3(1, ballPrefabClone.gameObject.transform.localScale.y - ((rememberLevel.level-1)*0.1f), 1);
				ballPrefabClone.gameObject.GetComponent<Renderer>().material = fishMaterials[rememberLevel.level-1];
			}
		}
		
		//za6to da ne gi sloja vsi4kite v 1 prazen obekt i samo nego da instantiate ???
		//6toto sum prost :D//!!!!!!!!!!!!!!!!!!//
		//GameObject maxClicksIndClone = (GameObject)Instantiate(buttons[0], new Vector3(-2.1f, -5.36f, 0), Quaternion.identity);
		//GameObject levelIndcClone = (GameObject)Instantiate(buttons[1], new Vector3(0.2f, -5.5f, 0), Quaternion.identity);
		//GameObject hintClone = (GameObject)Instantiate(buttons[2], new Vector3(-3f, -5.36f, 0), Quaternion.identity);
		GameObject test = (GameObject)Instantiate(buttons[3], new Vector3(0, -5.36f, 0), Quaternion.identity);
		LvlIndicator setLevelIndicator = test.transform.Find("LevelIndicator 1").GetComponent<LvlIndicator>();
		//MaxClicksIndicator setLevelIndicator = levelIndcClone.GetComponent<MaxClicksIndicator>();
		//LvlIndicator setLevelIndicator = levelIndcClone.GetComponent<LvlIndicator>();
		setLevelIndicator.lvl = LoadXMLData.idNumbers.IndexOf(ReloadLvl.levelIdCopy);
	}
	
	void levelTime() {
		lvlTime = (int)Time.timeSinceLevelLoad;
	}
}
