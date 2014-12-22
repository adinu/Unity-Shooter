using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Controller : MonoBehaviour {
	public GameObject bullet;
	public GameObject heroPos;
	Vector3 startPos;
	private int score;
	//public Text scoreText;
		
	void Start(){
		score = 0;
		//scoreText.text = "Score: "+score;
	}
	// Update is called once per frame
	void Update () {	

		if(Input.GetMouseButtonDown(0)){
			GameObject newBull = Instantiate (bullet, heroPos.transform.position, Quaternion.identity) as GameObject;
			newBull.SendMessage ("TheStart", Input.mousePosition);
		}
		//scoreText.text = "Score: "+score;
		//score++;
		/*
		int i = 0;
		while(i < Input.touchCount) {
			if (Input.GetTouch (i).phase == TouchPhase.Began) {
				GameObject newBull = Instantiate (bullet, heroPos.transform.position, Quaternion.identity) as GameObject;
				newBull.SendMessage ("TheStart", Input.mousePosition);
			}
			i++;
		}
		*/
	}

	public int getScore()
	{
		return this.score;
	}
	
	public void addScore(int points){
		score += points;	
	}
}
