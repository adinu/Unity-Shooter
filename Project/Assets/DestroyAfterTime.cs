﻿using UnityEngine;
using System.Collections;

public class DestroyAfterTime : MonoBehaviour {
	private float timeLeft = 1;

	void Update(){
		timeLeft -= Time.deltaTime;
		if ( timeLeft < 0 )
			Destroy(this.gameObject);
	}

}
