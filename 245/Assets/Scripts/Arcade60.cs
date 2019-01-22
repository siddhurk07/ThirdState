using UnityEngine;
using System.Collections;

public class Arcade60 : MonoBehaviour {
	
	public void OnMouseDown()
	{
		SpawnCollectible.CountCollectible = 1000;
		SpawnCollectible.low = 0;
		SpawnCollectible.high = 19;
		Destruct.Timer = 60;
		Destruct.check = 1;
		Destruct.check1 = 1;
		Destruct.check2 = 1;
		Restart.check = 2;
		LedEffect.t = 20f;
		Application.LoadLevel ("Game");
	}
}
