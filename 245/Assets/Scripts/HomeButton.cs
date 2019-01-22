using UnityEngine;
using System.Collections;

public class HomeButton : MonoBehaviour {
	public GameObject HomeB;
	public void OnMouseDown()
	{
		if( UnityAdsHelper.isReady())
		{
			UnityAdsHelper.ShowAd();
		}
		Time.timeScale = 1f;
		LedEffect.t = 2f;
		Application.LoadLevel ("Menu");
	}
}
