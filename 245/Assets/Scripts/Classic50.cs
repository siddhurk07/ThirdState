using UnityEngine;
using System.Collections;

public class Classic50 : MonoBehaviour {
	public void OnMouseDown()
	{
		SpawnCollectible.CountCollectible = 56;
		SpawnCollectible.low = 0;
		SpawnCollectible.high = 15;
		Destruct.check = 0;
		Destruct.check2 = 2;
		Restart.check = 3;
		LedEffect.t = 10f;
		Application.LoadLevel ("Game");
	}
}
