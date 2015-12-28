using UnityEngine;
using System.Collections;

public class LoadModes : MonoBehaviour {

	public GameObject mainCanvas;
	public GameObject pauseCanvas;

	public void playClassic()
	{
		Application.LoadLevel ("Classic Mode");
	}

	public void playZen()
	{
		Application.LoadLevel ("Zen Mode");
	}

	public void mainMenu()
	{
		Application.LoadLevel ("Main Menu");
	}

	public void pauseGame(){
		Time.timeScale = 0;
		pauseCanvas.SetActive (true);
	}

	public void resumeGame(){
		Time.timeScale = 1;
		pauseCanvas.SetActive (false);
	}
}
