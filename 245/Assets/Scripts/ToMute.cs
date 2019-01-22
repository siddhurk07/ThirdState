using UnityEngine;
using System.Collections;

public class ToMute : MonoBehaviour {
	public GameObject MuteButton;
	void OnMouseDown()
	{
		if(AudioListener.pause == true)
		{
			AudioListener.pause = false;
			MuteButton.SetActive (false);
		}
		else
		{
			AudioListener.pause = true;
			MuteButton.SetActive (true);
		}
	}
}
