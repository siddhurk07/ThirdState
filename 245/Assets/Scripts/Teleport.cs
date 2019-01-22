using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {
	public GameObject RecL,RecR,TelL,TelR;
	public static int j;
	void Update()
	{
		if(j==1)
		{
			StartCoroutine(Teleports(1));
			j=0;
		}
		if(j==2)
		{
			StartCoroutine(Teleports(2));
			j=0;
		}
	}
	public IEnumerator Teleports(int i)
	{
		if(i==1)
		{
			TelR.SetActive(true);
			RecL.SetActive(true);
			yield return new WaitForSeconds(0.1f);
			TelR.SetActive(false);
			RecL.SetActive(false);
		}
		if(i==2)
		{
			TelL.SetActive(true);
			RecR.SetActive(true);
			yield return new WaitForSeconds(0.1f);
			TelL.SetActive(false);
			RecR.SetActive(false);
		}
	}
}
