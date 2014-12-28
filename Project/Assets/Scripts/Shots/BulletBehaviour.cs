using UnityEngine;
using System.Collections;

public class BulletBehaviour : MonoBehaviour {
	public float timeLeft;
	public float force;
	public GameObject heroPos;
	private Vector3 startPos;
	// Use this for initialization

	void TheStart (Vector3 pos){
		this.startPos = pos;
		}


	void Start(){
		//Vector3 startPos = Input.mousePosition;
		//Ray ray = Camera.main.ScreenPointToRay(startPos);
		startPos = Camera.main.ScreenToWorldPoint(startPos);
		//startPos = ray.origin;
		//startPos.z = 0;
		//Vector3 direction = -heroPos.transform.position + startPos;
		Vector3 direction = new Vector3 (0, 1, 0);
		//direction = direction.normalized;
		this.gameObject.rigidbody2D.AddForce (direction *force);
	}
	
	void Update(){
		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
			Destroy(this.gameObject);
	}
}
