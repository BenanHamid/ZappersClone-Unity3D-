using UnityEngine;
using System.Collections;

public class LvlIndicator : MonoBehaviour {
	
	public int lvl;
	// Use this for initialization
	void Start () {
		
		TextMesh setLvlText = transform.GetComponentInChildren<TextMesh>();
		setLvlText.text = "Level " + (lvl + 1).ToString();
	}
}
