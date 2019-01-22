using UnityEngine;
using System.Collections;

public class Classic : MonoBehaviour {
	public GameObject BlackScreen,Classic50,Classic100;
	public void OnMouseDown()
	{
		BlackScreen.SetActive (true);
		iTween.MoveTo(Classic50,iTween.Hash("position",new Vector3(-0.11f,1.9f,-1),"time",1f,"ignoretimescale",true));
		iTween.MoveTo(Classic100,iTween.Hash("position",new Vector3(-0.11f,-1f,-1),"time",1));
		Ads.Down();
	}
}
