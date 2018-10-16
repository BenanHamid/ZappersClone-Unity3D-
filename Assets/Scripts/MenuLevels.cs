using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class MenuLevels : MonoBehaviour {
	
	public GameObject midi;
	int initIdNumbSize;
	private float SPACING = 0.3F;
	
	void Start () {
		LoadXMLData getInitArraySize = gameObject.GetComponent<LoadXMLData>();
		
		for(int i = 0; i < getInitArraySize.initArraySize; i++) {
			
			int x = i%2;
			int y = i/2;
			GameObject midiClone = (GameObject)Instantiate(midi, new Vector3(x*(1+SPACING)-0.5f,/*omg samo 1 minus mi trqlo !*/ -y*(1+SPACING)+2, 0), midi.transform.rotation);
			LevelsMidi getLevel = midiClone.GetComponent<LevelsMidi>();
			midiClone.GetComponentInChildren<TextMesh>().text = (i+1).ToString();
			getLevel.levelId = LoadXMLData.idNumbers[i];
		}
	}
}
