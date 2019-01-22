using UnityEngine;
using System.Collections;

public class move4 : MonoBehaviour {

	public Vector3 movement4 = new Vector3 (0.0f, 0.0f, 0.0f);
	public float speed4;
	void Update () 
	{
		movement4.x = Random.Range (0.5f, 2.0f);
		if (Time.timeScale == 1) 
		{
			GetComponent<Rigidbody2D>().AddForce (movement4 * -speed4 * 450);
		}
	}
}