using UnityEngine;
using System.Collections;

public class BulletSize : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.localScale =transform.lossyScale*0.99f;

	}
}
