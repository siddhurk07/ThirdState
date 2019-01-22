using UnityEngine;
using System.Collections;

public class animm_controller : MonoBehaviour {

	public GameObject self,selfbro;
	public Animator jar;
	public Animator jar2;
	public static bool pass;
	void Start ()
	{
		pass = false;
	}
	void FixedUpdate () 
	{
		if (set_play.started == false && pass==false) 
		{
			jar.Play("pausemenu_anim");
		}
		if (set_play.started == true)
		{


			if(pass==false)
			{
			jar.Play("nw1");
			GetComponent<Animation>().Stop ();
			jar.speed=0;
			pass=true;
			}
			if(pass==true)
			{
			selfbro.SetActive(true);
			}
		}
	}
}
