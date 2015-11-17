using UnityEngine;
using System.Collections;

public class ZenController : MonoBehaviour {
	
	GameObject newDot;
	float gameTime;
	int seconds;
	int minutes;
	float tempCount;
	
	void Start(){
		gameTime = 0;
		tempCount = 1;
		seconds = 0;
		minutes = 0;
	}
	
	void Update(){
		gameTime = gameTime + Time.deltaTime;
		tempCount = tempCount - Time.deltaTime;
		int dotChoose = Random.Range (0, 3);
		int redDotCount = 0;
		int blueDotCount = 0;
		seconds = (int)(gameTime % 60);
		minutes = (int)(gameTime / 60);

		if (tempCount < 0) {
			if (dotChoose == 2 && redDotCount < 3) {
				newDot = Instantiate (Resources.Load<GameObject> ("Red Dot"));
				redDotCount += redDotCount;
			} else {
				newDot = Instantiate (Resources.Load<GameObject> ("Blue Dot"));
				redDotCount = 0;
				blueDotCount += blueDotCount;
			}
			if (blueDotCount <= 40){
				tempCount = 1 - blueDotCount*(1/50);
			}
			else {
				tempCount = (1/5);
			}
			newDot.transform.position = new Vector2 (Random.Range (-8, 8), Random.Range(-3, 3));
		}
	}
}
