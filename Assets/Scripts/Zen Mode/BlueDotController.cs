using UnityEngine;
using System.Collections;

public class BlueDotController : MonoBehaviour {

	float deleteTimer;

	void Start () {
		deleteTimer = 1.5f;
	}
	
	void Update () {
		deleteTimer = deleteTimer - Time.deltaTime;
		if (deleteTimer < 0) {
			ZenController.misses = ZenController.misses + 1;
			Destroy(gameObject);
		}
	}
	void OnMouseDown(){
		ZenController.score = ZenController.score + 1;
		ZenController.playSound = 1;
		Destroy (gameObject);
	}
}
