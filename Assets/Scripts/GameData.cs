using UnityEngine;
using System;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameData : MonoBehaviour {
	public static GameData control;
	public int highScore;
	public int medHighScore;
	public int hardHighScore;
	
	void Awake(){
		if(control == null)
		{
			DontDestroyOnLoad(gameObject);
			control = this;
		}
		else if(control != this)
		{
			Destroy(this.gameObject);
		}	
	}
	public void Save()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/myPlayerInfo.dat");
		
		PlayerData  data = new PlayerData();
		data.highScore = highScore;
		bf.Serialize(file,data);
		file.Close();
	}
	public void Load()
	{
		if(File.Exists(Application.persistentDataPath + "/myPlayerInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/myPlayerInfo.dat",FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			highScore = data.highScore;
		}	
	}
	public void medSave ()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/myMedPlayerInfo.dat");
		
		PlayerData  data = new PlayerData();
		data.medHighScore = medHighScore;
		
		bf.Serialize(file,data);
		file.Close();
	}
	public void medLoad()
	{
		if(File.Exists(Application.persistentDataPath + "/myMedPlayerInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/myMedPlayerInfo.dat",FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			medHighScore = data.medHighScore;
		}	
	}
	public void hardSave ()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create(Application.persistentDataPath + "/myHardPlayerInfo.dat");
		
		PlayerData  data = new PlayerData();
		data.hardHighScore = hardHighScore;
		
		bf.Serialize(file,data);
		file.Close();
	}
	public void hardLoad()
	{
		if(File.Exists(Application.persistentDataPath + "/myHardPlayerInfo.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/myHardPlayerInfo.dat",FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize(file);
			hardHighScore = data.hardHighScore;
		}	
	}
}

[Serializable]
class PlayerData
{
	public int highScore;
	public int medHighScore;
	public int hardHighScore;
}
