using UnityEngine;
using System.Collections;

public class Rush60 : MonoBehaviour {
	public void OnMouseDown()
	{
		SpawnCollectible.CountCollectible = 1000;
		SpawnCollectible.low = 0;
		SpawnCollectible.high = 19;
		Restart.check = 5;
		Destruct.Timer = 0;
		Destruct.check = 1;
		Destruct.check1 = 0;
		Destruct.check2 = 0;
		Destruct.setScore = 60;
		LedEffect.t = 3f;
		Application.LoadLevel ("Game");
	}
}
