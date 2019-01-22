using UnityEngine;
using System.Collections;

public class back_from_info : MonoBehaviour {
	public GameObject infoscreen,sound,mute,nameplate,restorepurchases,back,about,gamename_msg,self,info,primescreen,nbpns;
	public GameObject ss_msg,tapto,ss_board;
	void OnMouseDown()
	{
		primescreen.GetComponent<Collider2D>().enabled = true;
		nbpns.SetActive (false);
		sound.SetActive (true);
		mute.SetActive (true);
		info.SetActive (true);
		ss_msg.SetActive (true);
		ss_board.SetActive (true);
		tapto.SetActive (true);
		infoscreen.SetActive (false);
		iTween.MoveTo(nameplate,iTween.Hash("position",new Vector3(-250,0,-92),"time",2.5f,"ignoretimescale",true,"transition","linear"));
		iTween.MoveTo(restorepurchases,iTween.Hash("position",new Vector3(250,40,-92),"time",2,"ignoretimescale",true,"transition","linear"));
		iTween.MoveTo(back,iTween.Hash("position",new Vector3(250,10,0),"time",2.5f,"ignoretimescale",true,"transition","linear"));
		iTween.MoveTo(about,iTween.Hash("position",new Vector3(-250,60,-92),"time",2,"ignoretimescale",true,"transition","linear"));
	}
}
