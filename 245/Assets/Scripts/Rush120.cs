using UnityEngine;
using System.Collections;

public class Rush120 : MonoBehaviour {
	public void OnMouseDown()
	{
		SpawnCollectible.CountCollectible = 1000;
		SpawnCollectible.low = 0;
		SpawnCollectible.high = 19;
		Restart.check = 6;
		Destruct.Timer = 0;
		Destruct.check = 1;
		Destruct.check1 = 0;
		Destruct.check2 = 1;
		Destruct.setScore = 120;
		LedEffect.t = 3f;
		Application.LoadLevel ("Game");
	}
}
