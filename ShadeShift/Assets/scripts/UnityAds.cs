using UnityEngine;
using System.Collections;

public class UnityAdsOnLoad : MonoBehaviour 
{
	public string zoneID = string.Empty;
	public float timeout = 15f;
	public bool disablePause;
	
	private float _startTime = 0f;
	private float _yieldTime = 1f;
	
	#if UNITY_IOS || UNITY_ANDROID
	IEnumerator Start ()
	{
		string zoneName = string.IsNullOrEmpty(zoneID) ? "the default ad placement zone" : zoneID;
		_startTime = Time.timeSinceLevelLoad;
		while (!UnityAdsHelper.isInitialized)
		{
			if (Time.timeSinceLevelLoad - _startTime > timeout)
			{
				Debug.LogWarning("Unity Ads failed to initialize in a timely manner. Ad will not be shown on load.");
				yield break;
			}
			yield return new WaitForSeconds(_yieldTime);
		}
		_startTime = Time.timeSinceLevelLoad;
		while (!UnityAdsHelper.isReady(zoneID))
		{
			if (Time.timeSinceLevelLoad - _startTime > timeout)
			{
				Debug.LogWarning(string.Format("The process of showing ads on load for {0} has timed out. Ad was not shown.",zoneName));
				yield break;
			}
			
			yield return new WaitForSeconds(_yieldTime);
		}
		
		Debug.Log(string.Format("Ads for {0} are available and ready. Showing ad now...",zoneName));
		UnityAdsHelper.ShowAd(zoneID,!disablePause);
	}
	#endif
}
