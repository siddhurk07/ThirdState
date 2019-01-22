using UnityEngine;
using System.Collections;

public class move_b2 : MonoBehaviour {

	public Vector3 movement1 = new Vector3 (1.0f, 0.0f, 0.0f);
	public GameObject player,self;

	void Update () {

		GetComponent<Rigidbody2D>().AddForce (movement1 * 400*-2);
		if (self.transform.position.x == -310 && self.transform.position.y == -115) {
			
			Destroy(self);
		}
	
	}
}
