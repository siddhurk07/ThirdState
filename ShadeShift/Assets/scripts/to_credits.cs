using UnityEngine;
using System.Collections;

public class to_credits : MonoBehaviour {
	public GameObject sound,mute;
	public GameObject credits;
	public GameObject nameplate,back,restorepurchases,about,gamename_msg,info,primescreen,nbpns,we;
	public GameObject ss_board,tapto;
	void Start()
	{
		nbpns.SetActive (false);
		we.SetActive (false);
	}
	void OnMouseDown()
	{
		nbpns.SetActive (true);
		ss_board.SetActive (false);
		tapto.SetActive(false);
		sound.SetActive (false);
		mute.SetActive (false);
		primescreen.GetComponent<Collider2D>().enabled = false;
		info.SetActive (false);
		iTween.MoveTo(nameplate,iTween.Hash("position",new Vector3(-62,0,-92),"time",1f,"transition","linear"));
		iTween.MoveTo(restorepurchases,iTween.Hash("position",new Vector3(100,40,-92),"time",0.5,"transition","linear"));
		iTween.MoveTo(back,iTween.Hash("position",new Vector3(100,10,-26),"time",1f,"transition","linear"));
		iTween.MoveTo(about,iTween.Hash("position",new Vector3(-83,60,-92),"time",0.5,"transition","linear"));
		credits.SetActive (true);
		iTween.FadeFrom (credits, iTween.Hash ("alpha", 0.0f, "time", 0.25,"transition","linear","transition","linear"));
	}
}
