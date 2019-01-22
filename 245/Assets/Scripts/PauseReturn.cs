using UnityEngine;
using System.Collections;

public class PauseReturn : MonoBehaviour {
	public GameObject Blackscreen,shadowP,Home,Play,Retry;
	public IEnumerator OnMouseDown()
	{
		shadowP.SetActive (false);
		Time.timeScale = 1f;
		yield return new WaitForSeconds (0.2f);
		shadowP.SetActive (true);
		Blackscreen.SetActive (false);
		iTween.MoveTo(Home,iTween.Hash("position",new Vector3(0f,-9f,-8),"time",1));
		iTween.MoveTo(Play,iTween.Hash("position",new Vector3(-5f,-1f,-8),"time",1));
		iTween.MoveTo(Retry,iTween.Hash("position",new Vector3(5f,-1f,-8),"time",1));
	}
}
