using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Destruct : MonoBehaviour 
{
	public GameObject[] Numbers;
	public TextMesh health,TimeKeep,Multiplier;
	public GameObject Timers,Multipliers;
	public static int GameValue;
	public static float Timer;
	public static int check,check1,setScore,Mul,check2;
	public int j;
	void Awake()
	{
		j = 2;
	}
	public void Start()
	{
		Mul = 1;
		GameValue = 10;
	}
	void Update()
	{
		MultiplierSet ();
		UpdateScore ();
		if(check == 1)
		{
			if(check1 == 1)
			{
				Timer = Timer - Time.deltaTime;
			}
			if(check1 == 0)
			{
				Timer = Timer + Time.deltaTime;
			}
			if(Timer >= 10)
			{
				TimeKeep.text = Timer.ToString("F1") + "s";
			}
			else
			{
				TimeKeep.text = "0"+Timer.ToString("F1") + "s";
			}
		}
		else
		{
			Timers.SetActive(false);
		}
	}
	public	void OnCollisionEnter2D(Collision2D other) 
	{
			Destroy (other.gameObject);
			if(other.gameObject.tag == "ob3" )
			{
				GameValue = GameValue - Mul*3;
				EffectController.j=1;
			}
			else if(other.gameObject.tag == "ob4")
			{
				GameValue = GameValue - Mul*4;
				EffectController.j=2;
			}
			else if(other.gameObject.tag == "ob5")
			{
				GameValue = GameValue - Mul*5;
				EffectController.j=3;
			}
			else if(other.gameObject.tag == "ob6")
			{
				GameValue = GameValue - Mul*6;
				EffectController.j=4;
			}
	}
	public void UpdateScore()
	{
		if(check == 1)
		{
			if(check1 ==  1)
			{
				if(GameValue <=0 || Timer<=0 || SpawnCollectible.CountCollectible <= 0)
				{
					LedEffect.t=2f;
					Multipliers.SetActive(false);
					Timers.SetActive(false);
					if(GameValue<0)
					{
						GameValue = 0;
					}
					check=0;
					Pause.j=1;
					GameOver.j=1;
				}
			}
			else if(check1 == 0)
			{
				if(GameValue <=0 || GameValue >= setScore || SpawnCollectible.CountCollectible<=0)
				{
					LedEffect.t = 2f;
					Multipliers.SetActive(false);
					Timers.SetActive(false);
					if(GameValue<0)
					{
						GameValue = 0;
					}
					check=0;
					Pause.j=1;
					GameOver.j=1;
				}
			}
		}
		if(check!=1)
		{
			if(GameValue <=0 || SpawnCollectible.CountCollectible <= 0)
			{
				LedEffect.t=2f;
				Multipliers.SetActive(false);
				if(GameValue<0)
				{
					GameValue = 0;
				}
				Pause.j=1;
				GameOver.j=1;
			}
		}
		if(GameValue < 100)
		{
			if(GameValue < 10)
			{
				health.text = "00"+GameValue.ToString ();
			}
			else
			{
				health.text = "0"+GameValue.ToString();
			}
		}
		else
		{
			health.text = GameValue.ToString();
		}
	}
	public void MultiplierSet()
	{
		if(check == 0)
		{
			if(check2 == 2)
			{
				if(SpawnCollectible.CountCollectible < 40)
				{
					Mul = 2;
				}
				if(SpawnCollectible.CountCollectible < 30 && SpawnCollectible.CountCollectible > 15)
				{
					Mul = 4;
				}
				if (SpawnCollectible.CountCollectible < 15)
				{
					Mul = 5;
				}
			}
			else if(check2 == 1)
			{
				if(SpawnCollectible.CountCollectible < 80 && SpawnCollectible.CountCollectible > 60)
				{
					Mul = 2;
				}
				if(SpawnCollectible.CountCollectible < 60 && SpawnCollectible.CountCollectible > 30)
				{
					Mul = 4;
				}
				if(SpawnCollectible.CountCollectible < 30)
				{
					Mul = 5;
				}
			}
		}
		if(check == 1 && check1 == 1)
		{
			if(check2==0)
			{
				if(Timer < 23 && Timer > 16)
				{
					Mul = 2;
				}
				else if (Timer <=16 && Timer >= 8)
				{
					Mul = 4;
				}
				else if (Timer <8)
				{
					Mul = 5;
				}
			}
			else if(check2==1)
			{
				if(Timer < 45 && Timer > 30)
				{
					Mul = 2;
				}
				else if (Timer <=30 && Timer >=15)
				{
					Mul = 4;
				}
				else if (Timer <15)
				{
					Mul = 5;
				}
			}
		}
		if(check == 1 && check1 == 0)
		{
			if(Timer > 60)
			{
				Mul = 5;
			}
			else if (Timer <=60 && Timer >=30)
			{
				Mul = 4;
			}
			else if (Timer <30 && Timer>10)
			{
				Mul = 2;
			}
		}
		Multiplier.text = Mul.ToString () + "x";
	}
}
