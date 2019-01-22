using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
	public static int check;
	public GameObject ShadowR;
	public void OnMouseDown()
	{
		Time.timeScale = 1f;
		if(check == 1)
		{
			SpawnCollectible.CountCollectible = 1000;
			Destruct.Timer = 30;
			Destruct.check = 1;
			LedEffect.t = 10f;
			Application.LoadLevel ("Game");
		}
		if(check == 2)
		{
			SpawnCollectible.CountCollectible = 1000;
			Destruct.Timer = 60;
			Destruct.check = 1;
			LedEffect.t = 20f;
			Application.LoadLevel ("Game");
		}
		if(check == 3)
		{
			SpawnCollectible.CountCollectible = 56;
			Destruct.check = 0;
			LedEffect.t = 10f;
			Application.LoadLevel ("Game");
		}
		if(check == 4)
		{
			SpawnCollectible.CountCollectible = 106;
			Destruct.check = 0;
			LedEffect.t = 10f;
			Application.LoadLevel ("Game");
		}
		if(check == 5)
		{
			SpawnCollectible.CountCollectible = 1000;
			Destruct.Timer = 0;
			Destruct.check = 1;
			Destruct.check1 = 0;
			Destruct.setScore = 60;
			LedEffect.t = 3f;
			Application.LoadLevel ("Game");
		}
		if(check == 6)
		{
			SpawnCollectible.CountCollectible = 1000;
			Destruct.Timer = 0;
			Destruct.check = 1;
			Destruct.check1 = 0;
			Destruct.setScore = 120;
			LedEffect.t = 3f;
			Application.LoadLevel ("Game");
		}
	}
}
