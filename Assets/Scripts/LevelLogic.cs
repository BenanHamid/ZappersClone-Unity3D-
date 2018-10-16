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
	static public int[] levelRawData;
	public Material[] fishMaterials = new Material[4];
	public static List<GameObject> fishCounter  = new List<GameObject>();
	public static int lvlTime;
	private float SPACING = 0.3F;
	public static string levelId;
	public static int maximumClicks;
	public static List<GameObject> ballCounter = new List<GameObject>();
	public GameObject[] buttons = new GameObject[4];
	void Start() {
		//viewPort = Camera.main.ScreenToViewportPoint(new Vector3(Screen.width, 0, 10));
		InvokeRepeating("levelTime", 0, 1);
		CreateGrid();
	}
	
	void CreateGrid() {
		for(int i = 0; i < levelRawData.Length; i++) {
			int x = i/5;
			int y = i%5;

			if(levelRawData[i] != 0) {
				
				GameObject ballPrefabClone = (GameObject)Instantiate(ballPrefab, new Vector3(x-2.5f, y-3, 0), transform.rotation);
				fishCounter.Add(ballPrefabClone);
				FishLogic rememberLevel =  ballPrefabClone.GetComponent<FishLogic>();
				rememberLevel.level = levelRawData[i];
				ballPrefabClone.gameObject.transform.localScale = new Vector3(1, ballPrefabClone.gameObject.transform.localScale.y - ((rememberLevel.level-1)*0.1f), 1);
				ballPrefabClone.gameObject.GetComponent<Renderer>().material = fishMaterials[rememberLevel.level-1];
			}
		}
		
		GameObject test = (GameObject)Instantiate(buttons[3], new Vector3(0, -5.36f, 0), Quaternion.identity);
		LvlIndicator setLevelIndicator = test.transform.Find("LevelIndicator 1").GetComponent<LvlIndicator>();
		setLevelIndicator.lvl = LoadXMLData.idNumbers.IndexOf(ReloadLvl.levelIdCopy);
	}
	
	void levelTime() {
		lvlTime = (int)Time.timeSinceLevelLoad;
	}
}
