using UnityEngine;
using System.Collections;
[System.Serializable]

public class PlayerController : MonoBehaviour {
	public GameObject bullet;
	Vector3 startPos;
	public Vector3 offsetBullet;
	public float speed;
	public float boundery;
	// Update is called once per frame
	void Update () {	
		/*
		if(Input.GetMouseButtonDown(0)){
			GameObject newBull = Instantiate (bullet, this.transform.position + offsetBullet, Quaternion.identity) as GameObject;
			newBull.SendMessage ("TheStart", Input.mousePosition);
		}
		//scoreText.text = "Score: "+score;
		//score++;
		*/
		int i = 0;
		while(i < Input.touchCount) {
			if (Input.GetTouch (i).phase == TouchPhase.Began) {
				GameObject newBull = Instantiate (bullet, this.transform.position, Quaternion.identity) as GameObject;
				newBull.SendMessage ("TheStart", Input.mousePosition);
			}
			i++;
		}

	}


	void FixedUpdate () {
		//float horizontal = Input.GetAxis("Horizontal");
		float horizontal = Input.acceleration.x;

		Vector3 movement = new Vector3 (horizontal, 0f, 0f);
		this.rigidbody2D.velocity = movement*speed;
		
		this.rigidbody2D.position = new Vector3 (
			Mathf.Clamp (this.transform.position.x, -boundery, boundery), this.transform.position.y, this.transform.position.z);
	}

		
}
