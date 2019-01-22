using UnityEngine;
using System.Collections;

public class Rush : MonoBehaviour {

	public GameObject BlackScreen,Rush60,Rush120;
	void OnMouseDown()
	{
		BlackScreen.SetActive (true);
		iTween.MoveTo(Rush60,iTween.Hash("position",new Vector3(-0.11f,1.9f,-1),"time",1f,"ignoretimescale",true));
		iTween.MoveTo(Rush120,iTween.Hash("position",new Vector3(-0.11f,-1f,-1),"time",1));
		Ads.Down ();
	}
}

