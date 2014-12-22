using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class display_score : MonoBehaviour {

	public GameObject ScoreTextUi;
	private GameObject controllerGameObject; // Drag the game controller here
	Text textScore;							//Drag the text ui object here
	int game_score_to_display;
	
	void Start () {
		controllerGameObject = GameObject.FindGameObjectWithTag ("GameController");
		game_score_to_display = 0;
		textScore = ScoreTextUi.GetComponent<Text>();  //The text component of a UI Text Object
		textScore.text="Score : " + game_score_to_display;
	}

	void Update () {
		game_score_to_display = controllerGameObject.GetComponent<Controller> ().getScore();
		textScore.text = "Score: " + game_score_to_display.ToString();
		//Debug.Log (game_score_to_display);
	}
}
