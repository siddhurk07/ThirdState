using UnityEngine;
using System.Collections;
public class Info : MonoBehaviour {
	public GameObject text245,Infotext;
	public static int j=0;
	public void OnMouseDown()
	{
		if(j == 0)
		{
			text245.SetActive (false);
			Infotext.SetActive (true);
			j=1;
		}
		else
		{
			text245.SetActive(true);
			Infotext.SetActive(false);
			j=0;
		}
	}
}
