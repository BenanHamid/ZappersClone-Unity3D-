using UnityEngine;
using System.Collections;

public class MaxClicksIndicator : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		StartCoroutine(showMaxClicks());
	}
	
	IEnumerator showMaxClicks() {
		//print(LevelLogic.maximumClicks);
		while(LevelLogic.maximumClicks >= 0) {
			TextMesh maxClicksIndic = transform.GetComponentInChildren<TextMesh>();
			maxClicksIndic.text = LevelLogic.maximumClicks.ToString();
			yield return null;
		}
	}
}
