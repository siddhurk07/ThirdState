using UnityEngine;
using System.Collections;

public class checkinstruction1 : MonoBehaviour {
	public GameObject ins1,ins2,ins3,info,ss_msg,tapto,noads,plus,minus,player;
	public  GameObject s1, s2, s3,s4,b1,b2;
	public static int inscheck=0;
	public int tempcheck=0;
	public int startanim=0;
	public mover playerscript;
	void Start () {
		s1.SetActive (false);
		s2.SetActive (false);
		s3.SetActive (false);
		s4.SetActive (false);
		b1.SetActive (false);
		b2.SetActive (false);
		playerscript.enabled = false;
		player.transform.position = new Vector3 (-90, 0, 0);
		set_play.startmoving = false;
		player.GetComponent<Rigidbody2D>().isKinematic = true;
		plus.SetActive (true);
		minus.SetActive (true);
		tapto.SetActive (false);
		ss_msg.SetActive (false);
		info.SetActive (false);
		noads.SetActive (false);
		}
	void Update()
	{
		if (shadeDecrement.slide1_touch_limit >= 5) 
		{
			plus.SetActive(false);
			minus.SetActive(false);
		}
	}
	void OnMouseDown()
	{
		s1.SetActive (true);
		s2.SetActive (true);
		s3.SetActive (true);
		s4.SetActive (true);
		s1.GetComponent<Rigidbody2D>().isKinematic = true;
		s2.GetComponent<Rigidbody2D>().isKinematic = true;
		s3.GetComponent<Rigidbody2D>().isKinematic = true;
		s4.GetComponent<Rigidbody2D>().isKinematic = true;
		b1.GetComponent<Rigidbody2D>().isKinematic = true;
		b2.GetComponent<Rigidbody2D>().isKinematic = true;
		if (tempcheck == 0) 
		{
			startanim = 1;
			iTween.FadeTo (ins1, iTween.Hash ("alpha", 0.0f, "time", 0.25, "easeType", "easeInSine", "oncomplete", "lauda"));
		    iTween.FadeFrom (ins2, iTween.Hash ("alpha", 0.0f, "time", 0.25, "easeType", "easeInSine"));			
			inscheck = 2;
			tempcheck = 1;
		}
	}
	void lauda()
	{
		ins1.SetActive(false);
		ins2.SetActive(true);
		ins3.SetActive(false);
	}
}
