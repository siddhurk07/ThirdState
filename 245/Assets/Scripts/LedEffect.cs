using UnityEngine;
using System.Collections;

public class LedEffect : MonoBehaviour {

	public GameObject Led1,Led2,Led3;
	public static float t=2;
	void Start()
	{
		StartCoroutine (Effect());
	}
	public IEnumerator Effect()
	{
		while(true)
		{
			Led3.SetActive (false);
			Led1.SetActive (true);
			yield return new WaitForSeconds (t);
			Led1.SetActive (false);
			Led2.SetActive (true);
			yield return new WaitForSeconds (t);
			Led2.SetActive (false);
			Led3.SetActive (true);
			yield return new WaitForSeconds (t);
			Led3.SetActive (false);
		}
	}
}
