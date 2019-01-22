using UnityEngine;
using System.Collections;

public class checkinstruction2 : MonoBehaviour {
	public GameObject ins1,ins2,ins3;
	public  GameObject s1, s2, s3,s4,b1,b2;
	public int tempcheck;
	void OnMouseDown()
	{
		score_rec.timer = 0;
		s1.SetActive (false);
		s2.SetActive (false);
		s3.SetActive (false);
		s4.SetActive (false);
		b1.GetComponent<Renderer>().material.color = new Color (33/255f,150/255f,243/255f);
		b2.GetComponent<Renderer>().material.color = new Color (33/255f,150/255f,243/255f);
		b1.SetActive (true);
		b2.SetActive (true);
		if (checkinstruction1.inscheck == 2) 
		{
			tempcheck=2;
		}
		if (tempcheck==2) 
		{
			iTween.FadeTo (ins2, iTween.Hash ("alpha", 0.0f, "time", 0.25, "easeType", "easeInSine", "oncomplete", "lauda"));
			iTween.FadeFrom (ins3, iTween.Hash ("alpha", 0.0f, "time", 0.25, "easeType", "easeInSine"));
			checkinstruction1.inscheck=3;
		}
	}
	void lauda()
	{
		ins1.SetActive(false);
		ins2.SetActive(false);
		ins3.SetActive (true);
	}
}
