using UnityEngine;
using System.Collections;

public class Ads : MonoBehaviour {

	public static void Down()
	{
		if( UnityAdsHelper.isReady())
		{
			UnityAdsHelper.ShowAd();
		}
	}
}
