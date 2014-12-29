using UnityEngine;
using System.Collections;

public class enemyClass : MonoBehaviour {
	public int HP;
	private GameObject GameController;
	public GameObject points;
	public int pointsToScore;
	public float movmentSpeed;
	public Sprite demaged;
	public Sprite dead;
	public AudioClip[] deathClips;
	public int rewardRatioBetween1To10; //1- low reward 10-highest reward
	private SpriteRenderer ren;	
	private Animator anim;
		

	void Start(){
		anim = GetComponent<Animator> ();
		ren = GetComponent<SpriteRenderer> ();
		GameController = GameObject.FindGameObjectWithTag ("GameController");
	}
	

	// Use this for initialization
	public void Hit (int hp) {
		HP= HP-hp;
		if (HP == 1)
			ren.sprite = demaged;
		if (HP <= 0) {
			ren.sprite = dead;
			Kill();
		}
	}

	private void Kill (){
		//Choose a reward according to odds 
		float ran = Random.Range (0, 10);
		if (ran > rewardRatioBetween1To10) {
				anim.SetBool ("Die", true);
				// Play a random audioclip from the deathClips array.
				int i = Random.Range (0, deathClips.Length);
				AudioSource.PlayClipAtPoint (deathClips [i], transform.position);

				Instantiate (points, this.transform.position, Quaternion.identity);
				GameController.GetComponent<Controller> ().addScore (pointsToScore);

		}
	}

	void OnCollisionEnter2D (Collision2D col){
		print (col.gameObject.tag);
		if (col.gameObject.tag == "heroBullet") {
			ENUM_bulletType shotType = col.gameObject.GetComponent<HeroShot>().eBulletType;
			Destroy(col.gameObject);
			switch(shotType)
			{
			case ENUM_bulletType.oneHPDown:
				Hit(1);
				break;
			case ENUM_bulletType.twoHPDown:
				Hit(2);
				break;
			case ENUM_bulletType.specialShot:
				break;
			}
		}

	}

	private void DestroyThis(){
		Destroy (this.gameObject);
	}
}
