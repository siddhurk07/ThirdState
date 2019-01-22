using UnityEngine;
using System.Collections;

public class SpawnPlayer : MonoBehaviour {

	public GameObject player;
	public GameObject[] pivots;
	public static int count,GridNo,range,j;
	public void Awake()
	{
			Spawn ();
	}
	public void Spawn()
	{
		range = Random.Range (0, 3);
		GridNo = range;
		count = range + 1;
	    Vector3 spawnPosition = new Vector3 ();
		spawnPosition = pivots [range].transform.position;
		Instantiate (player, spawnPosition, Quaternion.identity);
	}
}