using UnityEngine;
using System.Collections;

public class EnemyMovment : MonoBehaviour {
	//Vector3 movment = new Vector3(Random.Range(-3f,3f),Random.Range(-1f,0f),0);
	Vector3 movment = new Vector3(0,Random.Range(-1f,0f),0);
	public float speed;
	void FixedUpdate () {
		this.rigidbody2D.velocity = movment * speed;
	}
}
