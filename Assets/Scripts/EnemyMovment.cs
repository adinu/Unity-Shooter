using UnityEngine;
using System.Collections;

public class EnemyMovment : MonoBehaviour {
	Vector3 movment = new Vector3(0,-1,0);
	public float speed;
	void FixedUpdate () {
		this.rigidbody2D.velocity = movment * speed;
	}
}
