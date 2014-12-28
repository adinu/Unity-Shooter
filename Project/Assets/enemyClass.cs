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
	private SpriteRenderer ren;	
	private Animator anim;
		

	void Start(){
		anim = GetComponent<Animator> ();
		ren = GetComponent<SpriteRenderer> ();
		GameController = GameObject.FindGameObjectWithTag ("GameController");
	}
	

	// Use this for initialization
	public void Hit () {
		HP--;
		if (HP == 1)
			ren.sprite = demaged;
		if (HP == 0) {
			ren.sprite = dead;
			Kill();
		}
	}
	
	// Update is called once per frame
	private void Kill (){
		anim.SetBool ("Die", true);
		// Play a random audioclip from the deathClips array.
		int i = Random.Range(0, deathClips.Length);
		AudioSource.PlayClipAtPoint(deathClips[i], transform.position);

		Instantiate(points,this.transform.position,Quaternion.identity);
		GameController.GetComponent<Controller>().addScore(pointsToScore);

		}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "bullet") {
			Destroy(col.gameObject);
			this.Hit();
		}
	}

	private void DestroyThis(){
		Destroy (this.gameObject);
	}
}
