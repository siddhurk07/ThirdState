using UnityEngine;
using System.Collections;

public class temp_ball_fade : MonoBehaviour {
	public GameObject self;
	void Update () 
	{
		if (self.transform.position.y >= 148.0f && self.transform.position.y <= 188.0f) 
		{
			Destroy (self);
		}
	}
}
