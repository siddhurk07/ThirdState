using UnityEngine;
using System.Collections;

public class YesScript : MonoBehaviour {
	public GameObject Bichapp;
	void OnMouseDown()
	{
		if( UnityAdsHelper.isReady())
		{
			Ads.Down ();
		}
		else
		{
			Bichapp.SetActive (false);
		}
	}
	void Update()
	{
		if(UnityAdsHelper.check == true)
		{
			UnityAdsHelper.check =  false;
			Bichapp.SetActive(false);
			saveme.loadonsaveme=1;
			set_play.startmoving=false;
			mover.coin -= 50 * (PlayerPrefs.GetInt ("step")+1);
			PlayerPrefs.SetFloat("coins",PlayerPrefs.GetFloat ("coins")-(PlayerPrefs.GetInt ("step")+1)*50);
			PlayerPrefs.Save();
			saveme.taptodecide=1;
			PlayerPrefs.SetInt("step",PlayerPrefs.GetInt ("step")+1);
			PlayerPrefs.Save();
			Debug.Log(PlayerPrefs.GetInt ("step") +  "lauda");
			Application.LoadLevel(Application.loadedLevel);
		}
	}
}
