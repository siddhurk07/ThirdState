using UnityEngine;
using System.Collections;

public class Background : MonoBehaviour {
	public GameObject text245,infotext;
	void OnMouseDown()
	{
		if(Info.j==1)
		{
			infotext.SetActive(false);
			text245.SetActive(true);
			Info.j=0;
		}
	}
}
