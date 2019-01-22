using UnityEngine;
using System.Collections;

public class checkinstruction3 : MonoBehaviour {
	public GameObject ins1,ins2,ins3;
	public GameObject info, sound, mute,shadeshift_msg,tapto,noads;
	public  GameObject s1, s2, s3,s4,b1,b2;
	public int redirect=0;
	public mover playerscript;
	public GameObject taptocontinue;
	void OnMouseDown()
	{
		score_rec.scorecache = 0;
		score_rec.timer = 0;
		taptocontinue.SetActive (false);
		s1.SetActive (true);
		s2.SetActive (true);
		s3.SetActive (true);
		s4.SetActive (true);
		s1.GetComponent<Rigidbody2D>().isKinematic = false;
		s2.GetComponent<Rigidbody2D>().isKinematic = false;
		s3.GetComponent<Rigidbody2D>().isKinematic = false;
		s4.GetComponent<Rigidbody2D>().isKinematic = false;
		b1.GetComponent<Rigidbody2D>().isKinematic = false;
		b2.GetComponent<Rigidbody2D>().isKinematic = false;
		playerscript.enabled = true;
		s1.transform.position = new Vector3 (0,660, 0);
		s2.transform.position = new Vector3 (10,660, 0);
		s3.transform.position = new Vector3 (20,660, 0);
		s4.transform.position = new Vector3 (30,660, 0);
		b1.transform.position = new Vector3 (40,660, 0);
		b2.transform.position = new Vector3 (50,660, 0);
		score_rec.scorecache = 0;
		redirect += 1;
		if (redirect >= 1) 
		{
			iTween.FadeTo (ins3, iTween.Hash ("alpha", 0.0f, "time", 1, "easeType", "easeInSine", "oncomplete", "lauda"));
			shadeshift_msg.SetActive(true);
			tapto.SetActive(true);
			iTween.FadeTo (shadeshift_msg, iTween.Hash ("alpha", 1.0f, "time", 0.4, "easeType", "easeInSine","transition","linear"));
		}
	}
	void lauda()
	{
		ins1.SetActive(false);
		ins2.SetActive(false);
		ins3.SetActive(false);
		info.SetActive (true);
		sound.SetActive (true);
		mute.SetActive (true);

	}
}	

