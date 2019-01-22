using UnityEngine;
using System.Collections;

public class restart_from_pmenu : MonoBehaviour {
	void OnMouseDown()
	{
		score_rec.secs = 0;
		set_play.startmoving = false;
		saveme.taptodecide = 0;
		PlayerPrefs.SetInt ("step", 0);
		PlayerPrefs.Save ();
		Application.LoadLevel (Application.loadedLevel);
	}
}
