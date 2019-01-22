using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class restart_level : MonoBehaviour {
	public GameObject self,pause;
	void OnMouseDown()
	{
		score_rec.secs = 0;
		saveme.taptodecide = 0;
		animm_controller.pass = false;
		PlayerPrefs.SetInt ("step", 0);
		PlayerPrefs.Save ();
		Application.LoadLevel (Application.loadedLevel);
	}
}
