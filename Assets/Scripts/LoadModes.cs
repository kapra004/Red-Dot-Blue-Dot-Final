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
		//mainCanvas.SetActive (false);
		pauseCanvas.SetActive (true);
	}

	public void playGame(){
		Time.timeScale = 1;
		//mainCanvas.SetActive (true);
		pauseCanvas.SetActive (false);
	}
}
