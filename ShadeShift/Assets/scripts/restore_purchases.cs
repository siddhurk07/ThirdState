using UnityEngine;
using System.Collections;

public class restore_purchases : MonoBehaviour {
	void OnMouseDown()
	{
		mover.coin = 0;
		score_rec.scorecache = 0;
		score_rec.timer = 0;
		PlayerPrefs.SetInt ("showinstructions", 0);
		PlayerPrefs.SetFloat ("highscore", 0);
		PlayerPrefs.Save ();
		Application.LoadLevel ("scene1");
		Debug.Log ("restore sucessful");
	}
}
