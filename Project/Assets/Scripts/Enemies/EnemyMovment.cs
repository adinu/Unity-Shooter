using UnityEngine;
using System.Collections;

public enum Movment {Vertical,Horizontal,Wave};

public class EnemyMovment : MonoBehaviour {
	public float speed;
	private Vector3 directionOfMovment;
	
	public Movment movment;

	void Start(){
		switch (movment) {
			case Movment.Horizontal:
			directionOfMovment = new Vector3(1f,0f,0f);
				break;
			case Movment.Vertical:
			directionOfMovment = new Vector3(0f,-1f,0f);
				break;
			case Movment.Wave:

				break;
		}

	}

	void FixedUpdate () {
		this.rigidbody2D.velocity = directionOfMovment * speed;
	}

	public Movment getMovmentType(){
		return movment;
	}
}
