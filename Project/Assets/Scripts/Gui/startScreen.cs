using UnityEngine;
using System.Collections;

public class startScreen : MonoBehaviour {

	public Sprite pause_sprite1_Pause; // Drag your first sprite here
	public Sprite pause_sprite2_Play; // Drag your second sprite here
	public SpriteRenderer spriteRenderer; 

	private bool isGameStpoed=false;
	// Use this for initialization
	void Start () {
		// we are accessing the SpriteRenderer that is attached to the Gameobject

		spriteRenderer = GetComponent<SpriteRenderer>();
		Screen.autorotateToPortrait = false;
		Screen.orientation = ScreenOrientation.Landscape;
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
		if (isGameStpoed) 
		{
			Time.timeScale = 1;
			Debug.Log ("play pressed");
			isGameStpoed=false;
			spriteRenderer.sprite = pause_sprite2_Play; // set the sprite to sprite1- play
		} else 
		{
			Time.timeScale = 0;
			Debug.Log ("pause pressed");
			isGameStpoed=true;
			spriteRenderer.sprite = pause_sprite1_Pause; // set the sprite to sprite1- pause
		}
	}

	public void setSound(float sliderValue)
	{
		Debug.Log ("sound slider value= " + sliderValue);
		Debug.Log ("sound slider value test");
		AudioListener.volume = sliderValue/10;
	}
	// Quit the game
	public void Quit()
	{
		Application.Quit();
	}

}
