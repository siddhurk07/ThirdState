﻿using UnityEngine;
using System.Collections;

public class move3 : MonoBehaviour {

	public Vector3 movement3 = new Vector3 (0.0f, 0.0f, 0.0f);
	public float speed3;
	void Update () 
	{
		movement3.x = Random.Range (0.5f, 2.0f);
		if (Time.timeScale == 1) 
		{
			GetComponent<Rigidbody2D>().AddForce (movement3 * -speed3 * 390);
		}
	}
}
