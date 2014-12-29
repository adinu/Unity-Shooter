using UnityEngine;
using System.Collections;

public enum Enum_RewardType{BOMB, SHOTS, LIVES};


public class EnemyReward : MonoBehaviour {
	public float force;
	public Enum_RewardType rewardType;
	private GameObject GameController;

	// Use this for initialization
	void Start () {
		GameController = GameObject.FindGameObjectWithTag ("GameController");
		this.gameObject.rigidbody2D.AddForce((new Vector2(0,1)) * force);  //Pop the reward up

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Player") {
			Destroy(this.gameObject);
			//GameController.GetComponent<Controller>().addScore(pointsToScore);
		}
	}
}
