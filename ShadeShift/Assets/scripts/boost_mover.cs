using UnityEngine;
using System.Collections;

public class boost_mover : MonoBehaviour {

	public Vector3 movement1 = new Vector3 (1.0f, 0.0f, 0.0f);
	public GameObject player,self;
	void Update () 
	{
		self.GetComponent<Renderer>().sortingLayerName = player.GetComponent<Renderer>().sortingLayerName;
		GetComponent<Rigidbody2D>().AddForce (movement1 * 0.6f*-9800);
	}
}
