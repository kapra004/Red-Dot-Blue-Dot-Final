using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ZenController : MonoBehaviour {

	public static int misses;
	public static int score;
	public static int playSound;
	public AudioClip popSound;
	public Text timeText;
	public Text scoreText;
	public Text missesText;

	AudioSource source;
	GameObject newDot;
	float gameTime;
	int secondsOnes;
	int secondsTens;
	int minutes;
	int redDotCount;
	float blueDotCount;
	float tempCount;

	void Awake(){
		source = GetComponent<AudioSource>();
	}

	void Start(){
		playSound = 0;
		misses = 0;
		score = 0;
		gameTime = 0;
		tempCount = 1;
		secondsOnes = 0;
		secondsTens = 0;
		minutes = 0;
		redDotCount = 0;
		blueDotCount = 0;
		timeText.text = "0:00";
	}
	
	void Update(){
		gameTime = gameTime + Time.deltaTime;
		tempCount = tempCount - Time.deltaTime;
		int dotChoose = Random.Range (0, 3);
		secondsOnes = (int)(gameTime % 10);

		//Clock
		if (gameTime < 60) {
			secondsTens = (int)(gameTime / 10);
		} else {
			secondsTens = (int)((gameTime / 10) - 6*minutes);
		}

		minutes = (int)(gameTime / 60);

		timeText.text = minutes + ":" + secondsTens + secondsOnes;
		scoreText.text = "Score:" + score;
		missesText.text = "Misses:" + misses;

		//Game Over
		if (misses >= 3){
			Application.LoadLevel ("Game Over");
		}

		//New Dots
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
			newDot.transform.position = new Vector2 (Random.Range (-8.0f, 8.0f), Random.Range(-4.0f, 2.8f));
		}

		//Sound Effects
		if (playSound == 1) {
			source.PlayOneShot (popSound, 1.0F);
			playSound = 0;
		}
	}
}
