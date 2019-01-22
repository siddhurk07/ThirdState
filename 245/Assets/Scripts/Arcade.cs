using UnityEngine;
using System.Collections;

public class Arcade : MonoBehaviour {
	public GameObject BlackScreen, Arcade30, Arcade60;
	public void OnMouseDown()
	{
		BlackScreen.SetActive (true);
		iTween.MoveTo(Arcade30,iTween.Hash("position",new Vector3(-0.11f,1.9f,-1),"time",1f,"ignoretimescale",true));
		iTween.MoveTo(Arcade60,iTween.Hash("position",new Vector3(-0.11f,-1f,-1),"time",1));
		Ads.Down ();
	}
}
