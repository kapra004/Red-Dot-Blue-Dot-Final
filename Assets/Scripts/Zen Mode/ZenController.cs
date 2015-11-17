using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZenController : MonoBehaviour {

	public Text timeText;
	GameObject newDot;
	float gameTime;
	int seconds;
	int minutes;
	int redDotCount;
	float blueDotCount;
	float tempCount;
	
	void Start(){
		gameTime = 0;
		tempCount = 1;
		seconds = 0;
		minutes = 0;
		redDotCount = 0;
		blueDotCount = 0;
		timeText.text = "0:00";
	}
	
	void Update(){
		gameTime = gameTime + Time.deltaTime;
		tempCount = tempCount - Time.deltaTime;
		int dotChoose = Random.Range (0, 3);
		seconds = (int)(gameTime % 60);
		minutes = (int)(gameTime / 60);

		timeText.text = minutes + ":" + seconds;

		if (tempCount < 0) {
			if (dotChoose == 2 && redDotCount < 3) {
				newDot = Instantiate (Resources.Load<GameObject> ("Red Dot"));
				redDotCount = redDotCount + 1;
			} else {
				newDot = Instantiate (Resources.Load<GameObject> ("Blue Dot"));
				redDotCount = 0;
				blueDotCount = blueDotCount + 1;
			}
			if (blueDotCount < 66){
				tempCount = (1 - (blueDotCount/100));
			}
			else {
				tempCount = 0.33f;
			}
			newDot.transform.position = new Vector2 (Random.Range (-8.0f, 8.0f), Random.Range(-3.0f, 3.0f));
		}
	}
}
