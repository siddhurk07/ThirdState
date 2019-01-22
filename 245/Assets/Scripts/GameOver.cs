using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class GameOver : MonoBehaviour {
	public TextMesh Score,highscores,RushScore;
	public static int j=0;
	public GameObject Highscore,ScoreMesh,RushMesh;
	public int Highscore1,Highscore2,Highscore3,Highscore4;
	public float Highscore5,Highscore6;
	public void Update()
	{
		if(j==1)
		{
			Highscore.SetActive(true);
			UpdateScore ();
			j=0;
		}
	}
	void UpdateScore()
	{
		if(Restart.check == 1)
		{
			if(Highscore1 <= Destruct.GameValue)
			{
				Highscore1 = Destruct.GameValue;
				PlayerPrefs.SetInt("Score1", Highscore1);
				PlayerPrefs.Save();
			}
			Highscore1 = PlayerPrefs.GetInt("Score1");
			PlayerPrefs.Save();
			highscores.text = "Best : " + Highscore1;
		}
		if(Restart.check == 2)
		{
			if(Highscore2 <= Destruct.GameValue)
			{
				Highscore2 = Destruct.GameValue;
				PlayerPrefs.SetInt("Score2", Highscore2);
				PlayerPrefs.Save();
			}
			Highscore2 = PlayerPrefs.GetInt("Score2");
			PlayerPrefs.Save ();
			highscores.text = "Best : " + Highscore2;
		}
		if(Restart.check == 3)
		{
			if(Highscore3 <= Destruct.GameValue)
			{
				Highscore3 = Destruct.GameValue;
				PlayerPrefs.SetInt("Score3", Highscore3);
				PlayerPrefs.Save();
			}
			Highscore3 = PlayerPrefs.GetInt("Score3");
			PlayerPrefs.Save ();
			highscores.text = "Best : " + Highscore3;
		}
		if(Restart.check == 4)
		{
			if(Highscore4 <= Destruct.GameValue)
			{
				Highscore4 = Destruct.GameValue;
				PlayerPrefs.SetInt("Score4", Highscore4);
				PlayerPrefs.Save();
			}
			Highscore4 = PlayerPrefs.GetInt("Score4");
			PlayerPrefs.Save ();
			highscores.text = "Best : " + Highscore4;
		}
		if(Restart.check == 5)
		{
			if(Highscore5 <= Destruct.Timer && Destruct.GameValue >= Destruct.setScore)
			{
				Highscore5 = Destruct.Timer;
				PlayerPrefs.SetFloat("Score5", Highscore5);
				PlayerPrefs.Save();
			}
			Highscore5 = PlayerPrefs.GetFloat("Score5");
			PlayerPrefs.Save();
			highscores.text = "Best : " + Highscore5.ToString("F1");
		}
		if(Restart.check == 6)
		{
			if(Highscore6 <= Destruct.Timer && Destruct.GameValue >= Destruct.setScore)
			{
				Highscore6 = Destruct.Timer;
				PlayerPrefs.SetFloat("Score6", Highscore6);
				PlayerPrefs.Save();
			}
			Highscore6 = PlayerPrefs.GetFloat("Score6");
			PlayerPrefs.Save();
			highscores.text = "Best : " + Highscore6.ToString("F1");
		}
		if(Restart.check <= 4)
		{
			if(Destruct.GameValue < 100)
			{
				if(Destruct.GameValue < 10)
				{
					Score.text = "00"+Destruct.GameValue.ToString ();
				}
				else
				{
					Score.text = "0"+Destruct.GameValue.ToString();
				}
			}
			else
			{
				Score.text = Destruct.GameValue.ToString();
			}
		}
		else if(Restart.check >=5 && Destruct.GameValue >= Destruct.setScore)
		{
			ScoreMesh.SetActive(false);
			RushMesh.SetActive(true);
			RushScore.text = Destruct.Timer.ToString("F1");
		}
		else
		{
			Score.text = "999";
		}
	}
}
