using UnityEngine;
using System.Collections;

public class RedDotController : MonoBehaviour {
	
	float deleteTimer;
	
	void Start () {
		deleteTimer = 1.5f;
	}
	
	void Update () {
		deleteTimer = deleteTimer - Time.deltaTime;
		if (deleteTimer < 0) {
			Destroy(gameObject);
		}
	}
	void OnMouseDown(){
		if (ZenController.score == GameData.control.zenHighScore){
			GameData.control.zenSave ();
		}
		Application.LoadLevel ("Game Over");
	}
}