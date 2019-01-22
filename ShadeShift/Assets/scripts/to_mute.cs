using UnityEngine;
using System.Collections;

public class to_mute : MonoBehaviour {

	public GameObject wave;
	public int vol=1;
	void OnMouseDown()
	{
	   if (vol == 1)
		{
			wave.SetActive(false);
			AudioListener.pause=true;
			vol=0;
		}
		else if (vol == 0) 
		{
			wave.SetActive(true);
			AudioListener.pause=false;
			vol=1;
		}
	}
}
