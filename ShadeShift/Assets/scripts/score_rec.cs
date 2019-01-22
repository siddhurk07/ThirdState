using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class score_rec : MonoBehaviour {
	public TextMesh score_at_gameplay;
	public static float timer,t;
	public static float highscore;
	public static float scorecache=0;
	public TextMesh Highscore,score_at_gameover,savemecost,notenoughcoins,taptocontinue;
	public GameObject highscore_msg;
	public int i;
	public static float secs;
	void Start () 
	{
		scorecache = 0;
		timer = 0;
		secs = 0;        
		InvokeRepeating ("seccount", 1.0f, 1.0f);
		Highscore.text = "";
		if (saveme.taptodecide == 1) 
		{
			secs=PlayerPrefs.GetFloat("savemeadd");
			    
		}
		if (saveme.taptodecide == 0) 
		{
			secs=0;
		}
	}
	void Update () 
	{
		score_at_gameplay.GetComponent<Renderer>().sortingLayerName = "10";
		score_at_gameover.GetComponent<Renderer>().sortingLayerName = "8";
		Highscore.GetComponent<Renderer>().sortingLayerName = "8";
		savemecost.GetComponent<Renderer>().sortingLayerName = "10";
		notenoughcoins.GetComponent<Renderer>().sortingLayerName = "10";
		taptocontinue.GetComponent<Renderer>().sortingLayerName = "10";
		highscore = PlayerPrefs.GetFloat ("highscore");
		Highscore.text = Mathf.RoundToInt( PlayerPrefs.GetFloat ("highscore")) + "";
		if (set_play.startmoving == true) 
		{
			timer =secs ;
		    scorecache=timer;
			PlayerPrefs.SetFloat("savemeadd",scorecache);
			PlayerPrefs.Save();
			if(scorecache<=9)
			{
			score_at_gameplay.text =  "  "+Mathf.Round(scorecache)  ;
			score_at_gameover.text= "  "+Mathf.Round(scorecache) ;
			}
		if(scorecache>=10 && scorecache<=99)
		{
			score_at_gameplay.text =  " "+Mathf.Round(scorecache)  ;
			score_at_gameover.text= " "+Mathf.Round(scorecache) ;
		}
		if(scorecache>99)
		{
			score_at_gameplay.text =  Mathf.Round(scorecache) + ""  ;
			score_at_gameover.text= Mathf.Round(scorecache)+ "" ;
		}
		if (timer >= highscore)
		{
			 highscore_msg.SetActive(true);   
			 iTween.FadeTo(highscore_msg, iTween.Hash ("alpha", 0.0f, "time", 3, "easeType", "easeInSine","transition","easeInExpo"));
			 highscore = timer;
			 PlayerPrefs.SetFloat ("highscore", highscore);
			 PlayerPrefs.Save ();

		} 
		}
	}
	void seccount()
	{
		secs += 1;
	}
}
