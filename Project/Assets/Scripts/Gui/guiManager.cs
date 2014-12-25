using UnityEngine;
using System.Collections;

public class guiManager : MonoBehaviour {

	public Animator pauseMenu;
	private bool isGameStpoped=false;


	//sliding pannel after pressing pause
	public void OpenSettings()
	{
		pauseMenu.enabled = true;
		pauseMenu.SetBool ("isHidden", true);
	}
	void Start () {
		Screen.autorotateToPortrait = false;
		Screen.orientation = ScreenOrientation.Landscape;
		this.OpenSettings ();
	}
	
	// Update is called once per frame
	void Update () 	{}

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
		isGameStpoped = false;//for dubug ********

		if (isGameStpoped) 
		{

			Debug.Log ("play pressed");
			isGameStpoped=false;
			pauseMenu.SetBool ("isHidden", true);
			Debug.Log("hidden =true");
			this.pasueGame2();

		} else 
		{

			Debug.Log ("pause pressed");
			isGameStpoped=true;
			pauseMenu.SetBool ("isHidden", false);
			Debug.Log("hidden =false");
			//this.pasueGame2();

		//	Time.timeScale = 0;

		}
	}

	public void resumeGame()
	{
		Debug.Log ("play pressed");
		isGameStpoped=false;
		pauseMenu.SetBool ("isHidden", true);
		Debug.Log("hidden =true");
		Time.timeScale = 1;
	}
	public void pasueGame2()
	{

		Time.timeScale = 0;
	}

	// Quit the game
	public void Quit()
	{
		Application.Quit();
	}


	public void setSound(float sliderValue)
	{
		Debug.Log ("sound slider value= " + sliderValue);
		Debug.Log ("sound slider value test");
		AudioListener.volume = sliderValue/10;
	}


}
