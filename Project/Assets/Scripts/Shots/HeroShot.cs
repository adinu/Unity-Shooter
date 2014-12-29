using UnityEngine;
using System.Collections;

public enum ENUM_bulletType  {oneHPDown,twoHPDown, specialShot};

public class HeroShot : MonoBehaviour {
	public float timeLeft;
	public float force;
	public ENUM_bulletType eBulletType;
	public Vector3 direction;
	
	void Start(){
		//Vector3 direction = new Vector3 (0, 1, 0);  
		this.gameObject.rigidbody2D.AddForce (direction *force);
	}
	
	void Update(){
		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
			Destroy(this.gameObject);
	}

	void FixedUpdate () {  //decrease shot size as time progresses
		transform.localScale =transform.lossyScale*0.99f;
		
	}

}

