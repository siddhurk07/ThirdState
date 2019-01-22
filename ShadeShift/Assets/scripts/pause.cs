using UnityEngine;
using System.Collections;

public class pause : MonoBehaviour {

	public static bool pausecheck=true;
	public GameObject plus,minus,play,self,restart;
	public GameObject pausescreen;
 	void OnMouseDown()
	{
	
		set_play.musictoplay = 2;
		Time.timeScale = 0;
		pausescreen.SetActive (true);
		iTween.FadeTo (pausescreen, iTween.Hash ("alpha", 0.0f, "time", 0.25f, "easeType", "easeInSine"));
		iTween.MoveTo(play,iTween.Hash("position",new Vector3(20,-10,0),"time",1,"ignoretimescale",true,"transition","linear"));
		iTween.MoveTo(restart,iTween.Hash("position",new Vector3(20,20,0),"time",1,"ignoretimescale",true,"transition","linear"));
		play.SetActive (true);
		plus.SetActive(false);
		minus.SetActive(false);
		restart.SetActive (true);
	}
}
