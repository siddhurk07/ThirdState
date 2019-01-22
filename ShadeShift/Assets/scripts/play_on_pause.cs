using UnityEngine;
using System.Collections;

public class play_on_pause : MonoBehaviour {
	public GameObject plus,minus,pausescreen;
	public GameObject play,restart;
	void OnMouseDown()
	{
		set_play.musictoplay = 1;
		iTween.MoveTo(pausescreen,iTween.Hash("position",new Vector3(200.0f,-350.0f,-177f),"time",0.5,"ignoretimescale",true,"transition","linear"));
		iTween.MoveTo(play,iTween.Hash("position",new Vector3(20.0f,100.0f,-177f),"time",1,"ignoretimescale",true,"transition","linear"));
		iTween.MoveTo(restart,iTween.Hash("position",new Vector3(20.0f,110.0f,-177f),"time",1,"ignoretimescale",true,"transition","linear"));
		plus.SetActive(true);
		minus.SetActive(true);
		Time.timeScale = 1.0f;
	}
}
