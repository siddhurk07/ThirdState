using UnityEngine;
using System.Collections;

public class minus_bubble_spawnner : MonoBehaviour {
	public GameObject budaga;
	public static int left_spawn=1;
	void Start ()
	{
		StartCoroutine (spawn_left_bubble ());
	}
	IEnumerator spawn_left_bubble ()
	{
		while (true) 
		{
				Vector3 spawnPosition = new Vector3 (-273.0f, -106.0f, 0.0f);
				Quaternion spawnRotation = new Quaternion ();
				if (left_spawn % 2 == 0) 
				{
						Instantiate (budaga, spawnPosition, spawnRotation);
						yield return new WaitForSeconds (Random.Range (1.0f, 4.0f));
				}
		}
	}
}
