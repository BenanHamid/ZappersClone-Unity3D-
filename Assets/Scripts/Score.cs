using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {
	
	public GameObject scoreMenu;
	public GameObject retryMenu;
	bool isCreated = true;
	private int lvlPoints = 100;
	static int sumScore = 0;
	public static bool stopResumGame = false;
	//private int finTime;
	void Start () {
		//print ("max clicks " + FishLogic.maximumClicks);
		
	}
	
	public void scorings() {
		
		if(LevelLogic.maximumClicks <= 0 && LevelLogic.ballCounter.Count == 0 && LevelLogic.fishCounter.Count > 0) {
			//if(isCreated) {
				GameObject retry = (GameObject)Instantiate(retryMenu, new Vector3(0, 0, -1), transform.rotation);
				//isCreated = false;
			stopResumGame = true;
			//} 
		}
		
		if(LevelLogic.maximumClicks >= 0 && LevelLogic.ballCounter.Count == 0 && LevelLogic.fishCounter.Count == 0) {
			stopResumGame = true;
			GameObject menu = (GameObject)Instantiate(scoreMenu, new Vector3(0, 0, -1), transform.rotation);
			//menu.gameObject.get
			TextMesh scoreNumber = menu.transform.Find("ScoreNumber").GetComponent<TextMesh>();
			TextMesh timeNumb = menu.transform.Find("TimeNumb").GetComponent<TextMesh>();
			TextMesh totScoreNumber = menu.transform.Find("TotScoreNumber").GetComponent<TextMesh>();
			//nai veroqtno 6te se smeni za spored vsqko nivo...
			timeNumb.text = LevelLogic.lvlTime.ToString();
			scoreNumber.text = (LevelLogic.lvlTime + lvlPoints + LevelLogic.maximumClicks * lvlPoints).ToString();
			
			sumScore += LevelLogic.lvlTime + lvlPoints + LevelLogic.maximumClicks * lvlPoints;
			totScoreNumber.text = sumScore.ToString();
			
			string currLvlId = LevelLogic.levelId;
			int nextLvlIndex = LoadXMLData.idNumbers.IndexOf(ReloadLvl.levelIdCopy) + 1;
			//not sure if needed this if...
			if(nextLvlIndex <= LoadXMLData.idNumbers.Count-1  ) {
				string nextLvlId = LoadXMLData.idNumbers[nextLvlIndex];
				PlayerPrefs.SetString("locked" + nextLvlId, "no");
				print(nextLvlId);
				PlayerPrefs.Save();
			}
		}
	}
}
