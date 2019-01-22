using UnityEngine;
using System.Collections;

public class Arcade30 : MonoBehaviour {
	public void OnMouseDown()
	{
		SpawnCollectible.CountCollectible = 1000;
		SpawnCollectible.low = 0;
		SpawnCollectible.high = 19;
		Destruct.Timer = 30;
		Destruct.check = 1;
		Destruct.check1 = 1;
		Destruct.check2 = 0;
		Restart.check = 1;
		LedEffect.t = 10f;
		Application.LoadLevel ("Game");
	}
}
