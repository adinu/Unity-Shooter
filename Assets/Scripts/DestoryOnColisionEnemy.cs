using UnityEngine;
using System.Collections;

public class DestoryOnColisionEnemy : MonoBehaviour {
	private GameObject GameController;


	void Start(){
		GameController = GameObject.FindGameObjectWithTag ("GameController");
		}



	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.tag == "bullet")
		{
			Destroy(col.gameObject);
			Destroy (this.gameObject);
			//GameController.SendMessage("addScore", 1);
			GameController.GetComponent<Controller>().addScore(1);
		}
	}
		
}
