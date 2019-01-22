
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class saveme : MonoBehaviour {
	public const int step = 1;
	public static int loadonsaveme = 0;
	public static int taptodecide;
	public  int savemepenalty=50;
	public TextMesh savemepenaltytext;
	public int i=1;
	public GameObject Bicchap;
	void Start()
	{
		savemepenalty = 50;
	}
	void Update()
	{
		savemepenaltytext.text = savemepenalty * (PlayerPrefs.GetInt ("step")+1) + "";
	}
	void OnMouseDown()
	{
		if (mover.coin - savemepenalty * (PlayerPrefs.GetInt ("step")+1)  >=0)
		{
			loadonsaveme=1;
			set_play.startmoving=false;
			mover.coin -= 50 * (PlayerPrefs.GetInt ("step")+1);
			PlayerPrefs.SetFloat("coins",PlayerPrefs.GetFloat ("coins")-(PlayerPrefs.GetInt ("step")+1)*50);
			PlayerPrefs.Save();
			taptodecide=1;
			PlayerPrefs.SetInt("step",PlayerPrefs.GetInt ("step")+1);
			PlayerPrefs.Save();
			Debug.Log(PlayerPrefs.GetInt ("step") +  "lauda");
			Application.LoadLevel(Application.loadedLevel);

		}
		else 
		{
			Debug.Log ("buy somes coins");
			Bicchap.SetActive(true);
			taptodecide=0; 
		}
	}
	void OnApplicationQuit() 
	{
		PlayerPrefs.SetInt("step",0);
		PlayerPrefs.Save();
	}
}
