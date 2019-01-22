using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	public GameObject Blackscreen,Home,Play,Retry,Share;
	public static int j = 0;
	public void OnMouseDown()
	{
		Time.timeScale = 0.0f;
		Blackscreen.SetActive (true);
		iTween.MoveTo(Home,iTween.Hash("position",new Vector3(0,-3f,-8),"time",1,"ignoretimescale",true));
		iTween.MoveTo(Play,iTween.Hash("position",new Vector3(-1.27f,-2.2f,-8),"time",1,"ignoretimescale",true));
		iTween.MoveTo(Retry,iTween.Hash("position",new Vector3(1.32f,-2.2f,-8),"time",1,"ignoretimescale",true));
	}
	void Update()
	{
		if(j==1)
		{
			End();
			j=0;
		}
	}
	public void End()
	{
		Blackscreen.SetActive (true);
		iTween.MoveTo (Home, iTween.Hash ("position", new Vector3 (0, -3f, -8), "time", 1, "ignoretimescale", true));
		iTween.MoveTo (Share, iTween.Hash ("position", new Vector3 (-1.27f, -2.2f, -8), "time", 1, "ignoretimescale", true));
		iTween.MoveTo (Retry, iTween.Hash ("position", new Vector3 (1.32f, -2.2f, -8), "time", 1, "ignoretimescale", true));
	}

}
