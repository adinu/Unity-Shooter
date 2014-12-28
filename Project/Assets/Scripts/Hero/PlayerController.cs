using UnityEngine;
using System.Collections;
using UnityEngine.UI; 
[System.Serializable]

public class PlayerController : MonoBehaviour {
	public GameObject bullet;
	Vector3 startPos;
	public Vector3 offsetBullet;
	public float speed;
	public float boundery;
	bool facingRight;
	public int HP;
	Animator anim;
	private Image healthBarImage;

	void Start(){
		anim = GetComponent<Animator> ();
		facingRight = true;
		healthBarImage = GameObject.FindGameObjectWithTag ("healthBar").GetComponent<Image> ();

	}


	// Update is called once per frame
	void Update () {	

		if(Input.GetMouseButtonDown(0)){
			GameObject newBull = Instantiate (bullet, this.transform.position + offsetBullet, Quaternion.identity) as GameObject;
			newBull.SendMessage ("TheStart", Input.mousePosition);
		}
		//scoreText.text = "Score: "+score;
		//score++;
		/*
		int i = 0;
		while(i < Input.touchCount) {
			if (Input.GetTouch (i).phase == TouchPhase.Began) {
				GameObject newBull = Instantiate (bullet, this.transform.position, Quaternion.identity) as GameObject;
				newBull.SendMessage ("TheStart", Input.mousePosition);
			}
			i++;
		}
		*/

	}


	void FixedUpdate () {
		float horizontal;
		if (!Application.isMobilePlatform) {
			horizontal = Input.GetAxis ("Horizontal");
		} else { 	
			horizontal = Input.acceleration.x;
		}

		anim.SetFloat ("Speed", Mathf.Abs (horizontal));
		Vector3 movement = new Vector3 (horizontal, 0f, 0f);
		this.rigidbody2D.velocity = movement*speed;

		if ((horizontal < 0) && facingRight)
			Flip ();
		else if ((horizontal > 0) && !facingRight)
			Flip ();
		
		this.rigidbody2D.position = new Vector3 (
			Mathf.Clamp (this.transform.position.x, -boundery, boundery), this.transform.position.y, this.transform.position.z);
	}

	private void Flip(){
		facingRight = !facingRight;
		Vector3 scale = this.gameObject.transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
		
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "enemyBullet") {
			Destroy (col.gameObject);
			this.Hit();
		}
	}


	public void Hit () {
		HP--;
		healthBarImage.fillAmount = healthBarImage.fillAmount - 0.2f;

		if (HP == 0) {
			Kill();
		}
	}


	private void Kill (){
		Destroy (this.gameObject);
	}
}
