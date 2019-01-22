using UnityEngine;
using System.Collections;

public class Classic100 : MonoBehaviour {

	public void OnMouseDown()
	{
		SpawnCollectible.CountCollectible = 106;
		SpawnCollectible.low = 0;
		SpawnCollectible.high = 15;
		Destruct.check = 0;
		Destruct.check2 = 1;
		Restart.check = 4;
		LedEffect.t = 10f;
		Application.LoadLevel ("Game");
	}
}
