using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MenuLevels : MonoBehaviour {
	
	public GameObject midi;
	int initIdNumbSize;
	//mn vajno da si pravq takiva promenlivi posle vsi4kite navednuj da gi butam !!!
	private float SPACING = 0.3F;
	
	void Start () {
		
		/*PlayerPrefs.SetString("locked" + "lvlFour", "yes");
		PlayerPrefs.SetString("locked" + "lvlFive", "yes");
		PlayerPrefs.SetString("locked" + "lvlSix", "yes");
		PlayerPrefs.SetString("locked" + "lvlSeven", "yes");
		PlayerPrefs.SetString("locked" + "lvlEight", "yes");
		PlayerPrefs.SetString("locked" + "lvlNine", "yes");
		PlayerPrefs.SetString("locked" + "lvlTen", "yes");*/
		LoadXMLData getInitArraySize = gameObject.GetComponent<LoadXMLData>();
		//LevelsMidi.levelName = new string[LoadXMLData.idNumbers.Count];
		
		for(int i = 0; i < getInitArraySize.initArraySize; i++) {
			
			int x = i%2;
			int y = i/2;
			//print ("x " + x + " y " + y);
			GameObject midiClone = (GameObject)Instantiate(midi, new Vector3(x*(1+SPACING)-0.5f,/*omg samo 1 minus mi trqlo !*/ -y*(1+SPACING)+2, 0), midi.transform.rotation);
			LevelsMidi getLevel = midiClone.GetComponent<LevelsMidi>();
			midiClone.GetComponentInChildren<TextMesh>().text = (i+1).ToString();
			//getLevel.level = i+1;
			// learn it !!!<--
			//Hashtable lvlDataz = LoadXMLData.allData[LoadXMLData.idNumbers[i]] as Hashtable;
			//int maxClickz = (int)lvlDataz["maxClicks"];
			//int[] lvlRawData = (int[])lvlDataz["rawLevel"];
			
			//string lvlName = LoadXMLData.idNumbers[i];
			//bool isLocked = (bool)lvlDataz["locked"];
			//LevelsMidi.levelName = lvlName;
			
			getLevel.levelId = LoadXMLData.idNumbers[i];
			
			//podobno na tezi trqbva v klasa na midite da napravq
			
			//PlayerPrefs.SetString("locked" + lvlName, "yes");
			//tova 'yes' v PlayerPrefs e default value koeto mu zadavame !
			/*if(isLocked == true && PlayerPrefs.GetString("locked" + lvlName , "yes") == "yes") {
				
				getLevel.locked = true;
				
			} else {
				
				getLevel.locked = false;
				//unlockedLvls++;
			}*/
		}
	}
}
