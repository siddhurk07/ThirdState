using UnityEngine;
using System.Collections;

public class movecolletable : MonoBehaviour {
	public Vector3 movement1 = new Vector3 (1.0f, 0.0f, 0.0f);
	public GameObject self;
	void Update () 
	{
		GetComponent<Rigidbody2D>().AddForce (movement1 * Time.deltaTime*-10000);
	}
}
