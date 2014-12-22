using UnityEngine;
using System.Collections;

public class startScreen : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RestartLevel()
	{
		// Restart this level
		Application.LoadLevel(Application.loadedLevel);
	}

	public void startGame()
	{
		Application.LoadLevel(1);
		Debug.Log ("should load scene 1");
	}

	public void pasueTheGame () 
	{
		Time.timeScale = 0;
		Debug.Log ("pause pressed");
	}

	public void setSound(float sliderValue)
	{
		Debug.Log ("sound slider value= " + sliderValue);
		Debug.Log ("sound slider value test");
		AudioListener.volume = sliderValue/10;
	}

}
