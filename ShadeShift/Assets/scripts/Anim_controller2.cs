using UnityEngine;
using System.Collections;

public class Anim_controller2 : MonoBehaviour {
	public Animator jar2;
	void Update ()
	{
		if (animm_controller.pass == false) 
		{
			jar2.speed=0;
			GetComponent<Animation>().Stop ();
		}
		if (animm_controller.pass == true)
		{
			jar2.speed=1.0f;
			jar2.Play ("nw2");
		}
	}
}
