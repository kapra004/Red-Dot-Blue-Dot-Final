using UnityEngine;
using System.Collections;

public class LoadModes : MonoBehaviour {

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
}
