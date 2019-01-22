using UnityEngine;
using System.Collections;

public class BlackScreen : MonoBehaviour {

	public GameObject Blackscreen,Arcade30,Arcade60,Classic50,Classic100,Rush60,Rush120;
	public void OnMouseDown()
	{
		iTween.MoveTo(Arcade30,iTween.Hash("position",new Vector3(-6f,1.9f,-1),"time",2f,"ignoretimescale",true));
		iTween.MoveTo(Arcade60,iTween.Hash("position",new Vector3(6f,-1f,-1),"time",2));
		iTween.MoveTo(Classic50,iTween.Hash("position",new Vector3(-6f,1.9f,-1),"time",2f,"ignoretimescale",true));
		iTween.MoveTo(Classic100,iTween.Hash("position",new Vector3(6f,-1f,-1),"time",2));
		iTween.MoveTo(Rush60,iTween.Hash("position",new Vector3(-6f,1.9f,-1),"time",2f,"ignoretimescale",true));
		iTween.MoveTo(Rush120,iTween.Hash("position",new Vector3(6f,-1f,-1),"time",2));
		Blackscreen.SetActive (false);
	}
}
