using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class set_play : MonoBehaviour {
	public shade_spawwner N;
	public GameObject player,self,pause_button,mute,info,plus,minus,scorecard,score,play,restart,pausescreen;
	public GameObject sound,shadeshift_msg,cointext,coinboard;
	public GameObject menu_anim,game_anim;
	public  GameObject s1, s2, s3,s4,b1,b2;
	public static bool startmoving=false;
	public static bool mutememenu;
	public GameObject highscore;
	public static bool started=false;
	public  int showinstructions=0;
	public GameObject ins1,ins2,ins3,ins;
	public static int musictoplay,starttimer=0;
	public int checkins=0;
	public GameObject tapto,noads,taptocontinue;
	public mover playerscript;
	public GameObject scoreboard;
	void Start () 
	{
		score_rec.scorecache = 0;
		cointext.SetActive (false);
		PlayerPrefs.Save ();
		menu_anim.SetActive (true);
		game_anim.SetActive (false);
		if (PlayerPrefs.GetInt ("showinstructions") == 0)
		{
			mover.coin=100;
			checkins=1;
			score_rec.scorecache=0;
			taptocontinue.SetActive(false);
			score_rec.timer = 0;
			sound.SetActive(false);
			mute.SetActive(false);
			info.SetActive(false);
			started = false;
			highscore.SetActive (false);
			play.SetActive (false);
			restart.SetActive (false);
			pause_button.SetActive (false);
			Time.timeScale = 1.0f;
			N.enabled = false;
			plus.SetActive (false);
			minus.SetActive (false);
			score_rec.timer = 0.0f;
			score.SetActive (false);
			ins1.SetActive (true);
			ins2.SetActive (false);
			ins3.SetActive (false);
			Debug.Log("showing instructions");
		    showinstructions=1;
			PlayerPrefs.SetInt("showinstructions", showinstructions);
			PlayerPrefs.Save ();
		} 
		else if(PlayerPrefs.GetInt ("showinstructions") == 1) 
		{
			score_rec.scorecache=0;
			s1.SetActive (true);
			s2.SetActive (true);
			s3.SetActive (true);
			s4.SetActive (true);
			s1.GetComponent<Rigidbody2D>().isKinematic = false;
			s2.GetComponent<Rigidbody2D>().isKinematic = false;
			s3.GetComponent<Rigidbody2D>().isKinematic = false;
			s4.GetComponent<Rigidbody2D>().isKinematic = false;
			b1.GetComponent<Rigidbody2D>().isKinematic = false;
			b2.GetComponent<Rigidbody2D>().isKinematic = false;
			playerscript.enabled = true;
			s1.transform.position = new Vector3 (0,660, 0);
			s2.transform.position = new Vector3 (10,660, 0);
			s3.transform.position = new Vector3 (20,660, 0);
			s4.transform.position = new Vector3 (30,660, 0);
			b1.transform.position = new Vector3 (40,660, 0);
			b2.transform.position = new Vector3 (50,660, 0);
			ins.SetActive(false);
			Debug.Log("  not showing instructions");
			if(saveme.taptodecide==0)
			{

				tapto.SetActive(true);
				taptocontinue.SetActive(false);
				shadeshift_msg.SetActive(true);

			}
			else if(saveme.taptodecide==1)
			{
				tapto.SetActive(false);
				taptocontinue.SetActive(true);
				shadeshift_msg.SetActive(false);
			}
			score_rec.timer = 0; 
			sound.SetActive(true);
			mute.SetActive(true);
			info.SetActive(true);			
			started = false;
			highscore.SetActive (false);
			play.SetActive (false);
			restart.SetActive (false);
			pause_button.SetActive (false);
			Time.timeScale = 1.0f;
			N.enabled = false;
			plus.SetActive (false);
			minus.SetActive (false);
			score_rec.timer = 0.0f;
			score.SetActive (false);
			showinstructions=1;
			iTween.FadeFrom (shadeshift_msg, iTween.Hash ("alpha", 0.0f, "time", 0.4, "easeType", "easeInSine","transition","linear"));
			iTween.FadeTo (tapto, iTween.Hash ("alpha", 1.0f, "time", 0.5, "easeType", "easeInSine","transition","linear"));
		}
	}
     void OnMouseDown()
	{
		if (saveme.loadonsaveme == 1) 
		{
			saveme.loadonsaveme=0;
		}
		else if(saveme.loadonsaveme==0)
		{
			saveme.loadonsaveme=1;
		}
		game_anim.SetActive (true);
		menu_anim.SetActive (false);
		taptocontinue.SetActive (false);
		startmoving = true;
		cointext.SetActive (true);
		iTween.MoveTo (coinboard, iTween.Hash ("position", new Vector3 (-142, 45, 0), "time", 1.0f,"transition","linear"));
		iTween.MoveTo (scoreboard, iTween.Hash ("position", new Vector3 (-140, 67, 0), "time", 1.0f,"transition","linear"));
		noads.SetActive (false);
		tapto.SetActive (false);
		musictoplay = 1;
		iTween.MoveTo(shadeshift_msg,iTween.Hash("position",new Vector3(20,170,0),"time",3,"transition","linear"));
		plus.SetActive (true);
		minus.SetActive (true);
		Time.timeScale = 1.0f;
		started = true;
		pause_button.SetActive (true);
		scorecard.SetActive (true);
		score.SetActive (true);
		N.enabled = true;
		self.SetActive(false);
		iTween.MoveTo (player, iTween.Hash ("position", new Vector3 (-90, 0, 0), "time", 1.0f,"transition","linear"));
	}
}