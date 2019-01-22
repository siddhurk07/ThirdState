using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class mover : MonoBehaviour
{
    public Vector3 fdir = new Vector3 (0.0f, 0.0f, 0.0f);
	public Vector3 playerpos = new Vector3 (0, 0, 0);
	public Rigidbody2D player;
	public Vector3 accpos = new Vector3 (0, 0, 0);
	public static float coin,fgcoin;
	public GameObject shade1, shade2, shade3, shade4,gameover,plus,minus,pause,highscore,blackup,playerlauda,savemecost;
	public GameObject share, restart_go, best, gameover_msg,scoreslide,score_at_gameover,camflash,saveme,coinboard;
	public TextMesh coins;
	public static float temp ,accy;
	public shade_spawwner N;
	public score_rec S;
	public GameObject scoreboard;
	public GameObject cam;
	public TrailRenderer playertail;
	public GameObject score_dynamic,coin_dynamic;
	public float j;
	public GameObject[] tips;
	void Awake()
	{
		cam = Camera.main.gameObject;
	}
	void Start()
	{
		score_at_gameover.SetActive (false);
		player.transform.position=new Vector3(20,0,0);
		pause.SetActive (false);
		fgcoin = PlayerPrefs.GetFloat ("coins");
		coin = PlayerPrefs.GetFloat ("coins");
		PlayerPrefs.Save ();
		Debug.Log (PlayerPrefs.GetFloat ("coins") + "coins remaing!!!");
		coins.text = "";
	}
    void Update (){
		tips[0].GetComponent<Renderer>().sortingLayerName = "10";
		tips[1].GetComponent<Renderer>().sortingLayerName = "10";
		tips[2].GetComponent<Renderer>().sortingLayerName = "10";
		tips[3].GetComponent<Renderer>().sortingLayerName = "10";
		tips[4].GetComponent<Renderer>().sortingLayerName = "10";
		tips[5].GetComponent<Renderer>().sortingLayerName = "10";
		tips[6].GetComponent<Renderer>().sortingLayerName = "10";
		if (coin <= 0) 
		{
			coin=0;
		}
		coins.GetComponent<Renderer>().sortingLayerName = "10";
		playertail.sortingLayerName = "1";
		playertail.sortingOrder = 1;
	 	if (set_play.startmoving == false) 
		{
			accpos.y = Input.acceleration.y;
			accpos.x = Input.acceleration.x;
			accy = accpos.y;         				
			player.transform.position = new Vector3 (-160, 0, 0);				
		}
	    else if (set_play.startmoving == true)
		{

			player.transform.Translate (0,(Input.acceleration.y-accy)*600*Time.deltaTime ,0);
		}
		coins.text = PlayerPrefs.GetFloat ("coins") + "";
	    PlayerPrefs.SetFloat("coins",coin);
		PlayerPrefs.Save ();	      
		if (player.transform.position.y >= 40 ) 
		{
			player.transform.position=new Vector3(-90,40,0);
		}
		if (player.transform.position.y <= -75  ) 
		{
			player.transform.position=new Vector3(-90,-75,0);	
		}
		player.GetComponent<Animation>().Play ("jelly") ;    
	}
	/*************************************************************************************************/	   
	void OnCollisionEnter2D (Collision2D collision)
	{  
		if (collision.gameObject.tag == "shade1" && player.GetComponent<Renderer>().sortingLayerName=="4"  ) 
		{
			tips[Random.Range (0,6)].SetActive(true);
			coin += Mathf.Round( (score_rec.timer)*0.2f );
			PlayerPrefs.SetFloat("coins",coin);
			PlayerPrefs.Save ();
			set_play.startmoving=false;
			sfx_controller.sfxcollision=1;
			score_dynamic.SetActive(false);
			camflash.SetActive(true);
			iTween.FadeTo (camflash, iTween.Hash ("alpha", 0.0f, "time", 0.10f, "easeType", "easeInSine"));
			gameover.SetActive(true);
			iTween.FadeTo (gameover, iTween.Hash ("alpha", 0.0f, "time", 0.25f, "easeType", "easeInSine"));
			set_play.musictoplay = 2;
			iTween.FadeTo (camflash, iTween.Hash ("alpha", 255.0f, "time", 2, "easeType", "easeInSine","transition","linear"));
			iTween.MoveTo(camflash,iTween.Hash("position",new Vector3(50.0f,15f,810f),"time",0.2f,"ignoretimescale",true,"transition","linear"));
			Time.timeScale=0;
			plus.SetActive (false);
			pause.SetActive (false);
			minus.SetActive (false);
			Destroy(collision.gameObject);
			shade1.GetComponent<Collider2D>().isTrigger = true;
			shade2.GetComponent<Collider2D>().isTrigger = true;
			shade3.GetComponent<Collider2D>().isTrigger = true;
			shade4.GetComponent<Collider2D>().isTrigger = true;
			N.enabled=false;
			S.enabled=false;
			iTween.MoveTo (scoreboard, iTween.Hash ("position", new Vector3 (-220, 67, 0), "time", 1.0f,"transition","linear","ignoretimescale",true));
		    iTween.MoveTo(saveme,iTween.Hash("position",new Vector3(100f,0f,-135f),"time",1.5f,"ignoretimescale",true,"transition","easeInExpo"));
			iTween.MoveTo(restart_go,iTween.Hash("position",new Vector3(100.0f,-35.0f,-150),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(best,iTween.Hash("position",new Vector3(-70.0f,-35.0f,-30),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(gameover_msg,iTween.Hash("position",new Vector3(20f,45.0f,-177f),"time",1,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(scoreslide,iTween.Hash("position",new Vector3(-70.0f,0.0f,-30f),"time",1.5f,"ignoretimescale",true,"transition","linear","oncomplete","lauda"));
			score_at_gameover.SetActive(true);
			iTween.FadeFrom (score_at_gameover, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			highscore.SetActive(true);
			iTween.FadeFrom (highscore, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			playerlauda.SetActive(false);
			savemecost.SetActive(true);
			iTween.FadeFrom (savemecost, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
		}
		if (collision.gameObject.tag == "shade2" && player.GetComponent<Renderer>().sortingLayerName=="3" )
		{
			tips[Random.Range (0,6)].SetActive(true);
			coin+= Mathf.Round( (score_rec.timer)*0.2f );
			PlayerPrefs.SetFloat("coins",coin);
			PlayerPrefs.Save ();
			set_play.startmoving=false;
			sfx_controller.sfxcollision=1;
			score_dynamic.SetActive(false);
			iTween.MoveTo (scoreboard, iTween.Hash ("position", new Vector3 (-220, 67, 0), "time", 1.0f,"transition","linear","ignoretimescale",true));
			camflash.SetActive(true);
			iTween.FadeTo (camflash, iTween.Hash ("alpha", 0.0f, "time", 0.10f, "easeType", "easeInSine"));
			gameover.SetActive(true);
			iTween.FadeTo (gameover, iTween.Hash ("alpha", 0.0f, "time", 0.25f, "easeType", "easeInSine"));
			set_play.musictoplay = 2;
			iTween.MoveTo(camflash,iTween.Hash("position",new Vector3(50.0f,15f,810f),"time",0.2f,"ignoretimescale",true,"transition","linear"));
			Time.timeScale=0;
			plus.SetActive (false);
			pause.SetActive (false);
			minus.SetActive (false);
			Destroy(collision.gameObject);
			shade1.GetComponent<Collider2D>().isTrigger = true;
			shade2.GetComponent<Collider2D>().isTrigger = true;
			shade3.GetComponent<Collider2D>().isTrigger = true;
			shade4.GetComponent<Collider2D>().isTrigger = true;
			playerlauda.SetActive(false);
			N.enabled=false;
			S.enabled=false;
			iTween.MoveTo(saveme,iTween.Hash("position",new Vector3(100f,0f,-135f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(restart_go,iTween.Hash("position",new Vector3(100.0f,-35.0f,-150),"time", 1.5f,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(best,iTween.Hash("position",new Vector3(-70.0f,-35.0f,0f),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(gameover_msg,iTween.Hash("position",new Vector3(20f,45.0f,-177f),"time",1,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(scoreslide,iTween.Hash("position",new Vector3(-70.0f,0.0f,0f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			iTween.FadeTo (highscore, iTween.Hash ("alpha", 0.0f, "time", 2, "easeType", "easeInSine","transition","linear"));
			score_at_gameover.SetActive(true);
			iTween.FadeFrom (score_at_gameover, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			highscore.SetActive(true);
			iTween.FadeFrom (highscore, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			savemecost.SetActive(true);
			iTween.FadeFrom (savemecost, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
		}
		if (collision.gameObject.tag == "shade3" && player.GetComponent<Renderer>().sortingLayerName=="2"  ) 
		{
			tips[Random.Range (0,6)].SetActive(true);
			coin+=  Mathf.Round( (score_rec.timer)*0.2f );
			PlayerPrefs.SetFloat("coins",coin);
			PlayerPrefs.Save ();
			set_play.startmoving=false;
			sfx_controller.sfxcollision=1;
			score_dynamic.SetActive(false);
			iTween.MoveTo (scoreboard, iTween.Hash ("position", new Vector3 (-220, 67, 0), "time", 1.0f,"transition","linear","ignoretimescale",true));
			camflash.SetActive(true);
			iTween.FadeTo (camflash, iTween.Hash ("alpha", 0.0f, "time", 0.10f, "easeType", "easeInSine"));
			gameover.SetActive(true);
			iTween.FadeTo (gameover, iTween.Hash ("alpha", 0.0f, "time", 0.25f, "easeType", "easeInSine"));
			set_play.musictoplay = 2;
			iTween.MoveTo(camflash,iTween.Hash("position",new Vector3(50.0f,15f,810f),"time",0.2f,"ignoretimescale",true,"transition","linear"));
			Time.timeScale=0;
			plus.SetActive (false);
			minus.SetActive (false);
			pause.SetActive (false);
			Destroy(collision.gameObject);
			shade1.GetComponent<Collider2D>().isTrigger = true;
			shade2.GetComponent<Collider2D>().isTrigger = true;
			shade3.GetComponent<Collider2D>().isTrigger = true;
			shade4.GetComponent<Collider2D>().isTrigger = true;
			playerlauda.SetActive(false);
			N.enabled=false;
			S.enabled=false;
			iTween.MoveTo(saveme,iTween.Hash("position",new Vector3(100f,0f,-135f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(restart_go,iTween.Hash("position",new Vector3(100.0f,-35.0f,-150),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(best,iTween.Hash("position",new Vector3(-70.0f,-35.0f,0f),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(gameover_msg,iTween.Hash("position",new Vector3(20f,45.0f,-177f),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(scoreslide,iTween.Hash("position",new Vector3(-70.0f,0.0f,0f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			score_at_gameover.SetActive(true);
			iTween.FadeFrom (score_at_gameover, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			highscore.SetActive(true);
			iTween.FadeFrom (highscore, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));		
			savemecost.SetActive(true);
			iTween.FadeFrom (savemecost, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			Ads.Down();
		}
		if (collision.gameObject.tag == "shade4" && player.GetComponent<Renderer>().sortingLayerName=="1" ) 
		{
			tips[Random.Range (0,6)].SetActive(true);
			coin+= Mathf.Round( (score_rec.timer)*0.2f );
			PlayerPrefs.SetFloat("coins",coin);
			PlayerPrefs.Save ();
			set_play.startmoving=false;
			sfx_controller.sfxcollision=1;
			score_dynamic.SetActive(false);
			iTween.MoveTo (scoreboard, iTween.Hash ("position", new Vector3 (-220, 67, 0), "time", 1.0f,"transition","linear","ignoretimescale",true));
			camflash.SetActive(true);
			iTween.FadeTo (camflash, iTween.Hash ("alpha", 0.0f, "time", 0.10f, "easeType", "easeInSine"));
			gameover.SetActive(true);
			iTween.FadeTo (gameover, iTween.Hash ("alpha", 0.0f, "time", 0.25f, "easeType", "easeInSine"));
			set_play.musictoplay = 2;
			iTween.MoveTo(camflash,iTween.Hash("position",new Vector3(50.0f,15f,810f),"time",0.2f,"ignoretimescale",true,"transition","linear"));
			Time.timeScale=0;
			plus.SetActive (false);
			minus.SetActive (false);
			pause.SetActive (false);
			Destroy(collision.gameObject);
			shade1.GetComponent<Collider2D>().isTrigger = true;
			shade2.GetComponent<Collider2D>().isTrigger = true;
			shade3.GetComponent<Collider2D>().isTrigger = true;
			shade4.GetComponent<Collider2D>().isTrigger = true;
			playerlauda.SetActive(false);
			N.enabled=false;
			S.enabled=false;
			iTween.MoveTo(saveme,iTween.Hash("position",new Vector3(100f,0f,-135f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(restart_go,iTween.Hash("position",new Vector3(100.0f,-35.0f,-150),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(best,iTween.Hash("position",new Vector3(-70.0f,-35.0f,0f),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(gameover_msg,iTween.Hash("position",new Vector3(20f,45.0f,-177f),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(scoreslide,iTween.Hash("position",new Vector3(-70.0f,0.0f,0f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			score_at_gameover.SetActive(true);
			iTween.FadeFrom (score_at_gameover, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			highscore.SetActive(true);
			iTween.FadeFrom (highscore, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			savemecost.SetActive(true);
			iTween.FadeFrom (savemecost, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));	
		}
		if (collision.gameObject.tag == "blackup"  ) 
		{
			tips[Random.Range (0,6)].SetActive(true);
			coin+= Mathf.Round( (score_rec.timer)*0.2f );
			PlayerPrefs.SetFloat("coins",coin);
			PlayerPrefs.Save ();
			set_play.startmoving=false;
			sfx_controller.sfxcollision=1;
			score_dynamic.SetActive(false);
			iTween.MoveTo (scoreboard, iTween.Hash ("position", new Vector3 (-220, 67, 0), "time", 1.0f,"transition","linear","ignoretimescale",true));
			camflash.SetActive(true);
			iTween.FadeTo (camflash, iTween.Hash ("alpha", 0.0f, "time", 0.10f, "easeType", "easeInSine"));
			gameover.SetActive(true);
			iTween.FadeTo (gameover, iTween.Hash ("alpha", 0.0f, "time", 0.25f, "easeType", "easeInSine"));
			set_play.musictoplay = 2;
			Destroy(collision.gameObject);
			iTween.MoveTo(camflash,iTween.Hash("position",new Vector3(50.0f,15f,810f),"time",0.2f,"ignoretimescale",true,"transition","easeInExpo"));
			Time.timeScale=0;
			plus.SetActive (false);
			pause.SetActive (false);
			minus.SetActive (false);
			playerlauda.SetActive(false);
			N.enabled=false;
			S.enabled=false;
			iTween.MoveTo(saveme,iTween.Hash("position",new Vector3(100f,0f,-135f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(restart_go,iTween.Hash("position",new Vector3(100.0f,-35.0f,-150),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(best,iTween.Hash("position",new Vector3(-70.0f,-35.0f,0f),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(gameover_msg,iTween.Hash("position",new Vector3(20f,45.0f,-177f),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(scoreslide,iTween.Hash("position",new Vector3(-70.0f,0.0f,0f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			score_at_gameover.SetActive(true);
			iTween.FadeFrom (score_at_gameover, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			highscore.SetActive(true);
			iTween.FadeFrom (highscore, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			savemecost.SetActive(true);
			iTween.FadeFrom (savemecost, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			Ads.Down();
		}
		if (collision.gameObject.tag == "blackdown") 
		{
			tips[Random.Range (0,6)].SetActive(true);
			coin+= Mathf.Round( (score_rec.timer)*0.2f );
			PlayerPrefs.SetFloat("coins",coin);
			PlayerPrefs.Save ();
			set_play.startmoving=false;
			sfx_controller.sfxcollision=1;
			score_dynamic.SetActive(false);
			iTween.MoveTo (scoreboard, iTween.Hash ("position", new Vector3 (-220, 67, 0), "time", 1.0f,"transition","linear","ignoretimescale",true));
			camflash.SetActive(true);
			iTween.FadeTo (camflash, iTween.Hash ("alpha", 0.0f, "time", 0.10f, "easeType", "easeInSine"));
			gameover.SetActive(true);
			iTween.FadeTo (gameover, iTween.Hash ("alpha", 0.0f, "time", 0.25f, "easeType", "easeInSine"));
			set_play.musictoplay = 2;
			Destroy(collision.gameObject);
			iTween.MoveTo(camflash,iTween.Hash("position",new Vector3(50.0f,15f,810f),"time",0.2f,"ignoretimescale",true,"transition","easeInExpo"));
			Time.timeScale=0;
			plus.SetActive (false);
			minus.SetActive (false);
			pause.SetActive (false);
			playerlauda.SetActive(false);
			N.enabled=false;
			S.enabled=false;
			iTween.MoveTo(saveme,iTween.Hash("position",new Vector3(100f,0f,-135f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(restart_go,iTween.Hash("position",new Vector3(100.0f,-35.0f,-150),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(best,iTween.Hash("position",new Vector3(-70.0f,-35.0f,0f),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(gameover_msg,iTween.Hash("position",new Vector3(20f,45.0f,-177f),"time",2,"ignoretimescale",true,"transition","linear"));
			iTween.MoveTo(scoreslide,iTween.Hash("position",new Vector3(-70.0f,0.0f,0f),"time",1.5f,"ignoretimescale",true,"transition","linear"));
			iTween.FadeTo (gameover, iTween.Hash ("alpha", 0.0f, "time", 1, "easeType", "easeInSine"));
			score_at_gameover.SetActive(true);
			iTween.FadeFrom (score_at_gameover, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			highscore.SetActive(true);
			iTween.FadeFrom (highscore, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
			savemecost.SetActive(true);
			iTween.FadeFrom (savemecost, iTween.Hash ("alpha", 0.0, "time", 1, "easeType", "easeInSine","transition","linear","ignoretimescale",true));
		}
		if (collision.gameObject.tag == "collectable") 
		{
			Destroy(collision.gameObject);
			Debug.Log(" destroyed");
			if(player.GetComponent<Renderer>().material.color==blackup.GetComponent<Renderer>().material.color )
			{   Debug.Log("coin fetched!");
			    coin=coin+1;
				PlayerPrefs.SetFloat("coins",coin);
				PlayerPrefs.Save();
				Debug.Log("trueeee");
			}
		}
		if (collision.gameObject.tag == "boost") 
		{
			Destroy(collision.gameObject);
			StartCoroutine(inctimescale());
			player.GetComponent<Collider2D>().isTrigger=true;
			StartCoroutine(  activatecollision());
			sfx_controller.sfxboost=1;
		}
	}	
	IEnumerator activatecollision()
	{
		yield return new WaitForSeconds (10);
		player.GetComponent<Collider2D>().isTrigger = false;
		Time.timeScale = 1.0f;
		Time.fixedDeltaTime = 0.02f * Time.timeScale;			
	}
	IEnumerator inctimescale()
	{
		Time.timeScale = 2.0f;
		yield return new WaitForSeconds(3.5f);
		Time.timeScale = 3.0f;
	}
}
