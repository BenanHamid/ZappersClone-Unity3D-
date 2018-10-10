using UnityEngine;
using System.Collections;

public class BGResizer : MonoBehaviour {
	
	private Vector3 viewPos;
	private float MULTIPLY = 2F;
	void Start () {
		//renderer.material.mainTexture.width = 5;
		//renderer.material.mainTextureScale = new Vector2(transform.lossyScale.x*0.5f,transform.lossyScale.x*0.5f);
		//PO TOzi na4in polu4avam to4no Scaling na pixel-ite, a ne samite pixel-i  !!!
		//myTexture = renderer.material.mainTexture;
		viewPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 11.1f));
		transform.localScale = new Vector3(viewPos.x*MULTIPLY, viewPos.y*MULTIPLY, 0);
		
		//print(gameObject.renderer.bounds.size);
	}
}
