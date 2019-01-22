using UnityEngine;
using System.Collections;

public class final_score : MonoBehaviour {
	public GUIText finalscore;
	public GameObject scorecard;
	void Start ()
	{
		finalscore.text = "";
	}
	void Update ()
	{
		finalscore.text = "Score : " + score_rec.timer ;
		scorecard.SetActive (false);
	}
}
