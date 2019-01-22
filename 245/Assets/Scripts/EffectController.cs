using UnityEngine;
using System.Collections;

public class EffectController : MonoBehaviour {

	public GameObject E1,E2,E3,E4;
	public GameObject[] pivots;
	public static int j=0;
	void Update()
	{
		if(j>0)
		{
			Down();
			j=0;
		}
	}
	public void Down()
	{
		Vector3 spawnPosition = new Vector3 ();
		spawnPosition = pivots [0].transform.position;
		if (j == 1)
			Destroy(Instantiate (E1, spawnPosition, Quaternion.identity),2.0f);
		else if (j == 2)
			Destroy(Instantiate (E2, spawnPosition, Quaternion.identity),2.0f);
		else if (j == 3)
			Destroy(Instantiate (E3, spawnPosition, Quaternion.identity),2.0f);
		else if (j == 4)
			Destroy(Instantiate (E4, spawnPosition, Quaternion.identity),2.0f);
	}
}
