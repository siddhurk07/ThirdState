using UnityEngine;
using System.Collections;

public class move1 : MonoBehaviour {

	public Vector3 movement1 = new Vector3 (0.0f, 0.0f, 0.0f);
	public float speed1;
	void Update () 
	{
		movement1.x = Random.Range (0.5f, 2.0f);
		if (Time.timeScale == 1) 
		{
			GetComponent<Rigidbody2D>().AddForce (movement1 * -speed1 * 330);
		}
	}
}