using UnityEngine;
using System.Collections;

public class shade_spawwner : MonoBehaviour {
	public Rigidbody2D player;
	public GameObject[] shades;
	public  GameObject blackup, blackdown,collectable,boost;
	public float k,l;
	public Vector3 blackup_pos = new Vector3 (0, 0, 0);
	public Vector3 blackdown_pos = new Vector3 (0, 0, 0);
	public Vector3 playerpos = new Vector3 (0, 0, 0);
	public static float y1, y2;
	public int colorselector;
	public static Color col;
	void Start()
	{
		StartCoroutine (spawn ());
		StartCoroutine (waitb ());
		StartCoroutine (spawnboost ());
	}
/*********************************************************************************/
	void Update()
	{
		blackup_pos = blackup.transform.position;
		blackdown_pos = blackdown.transform.position;
		playerpos = player.position;
		l = Random.Range (1, 3)*4;
	}
	IEnumerator spawn ()
	{      
			while (true) 
			{
			Vector3 spawnPosition = new Vector3 (200 + k, -14.43f, 0.0f);
			Quaternion spawnRotation = new Quaternion ();
			Instantiate (shades [Random.Range(0,11)], spawnPosition, spawnRotation);
			yield return new WaitForSeconds (Random.Range( 1.0f , 4.0f) );
			k = k + 50;
			if(k>800)
			{	
				k=300;
			}
			}
				
	}
/*********************************************************************************************/
	IEnumerator waitb()
	{
		while (true) 
		{
			colorselector = Random.Range (1, 4);
			Debug.Log("randgen" + colorselector);
			switch (colorselector) {
			case 1:
			{ 	blackup.GetComponent<Renderer>().material.color = new Color (144 / 255f, 202 / 255f, 249 / 255f);
				blackdown.GetComponent<Renderer>().material.color = new Color (144 / 255f, 202 / 255f, 249 / 255f);
				col= new Color (144 / 255f, 202 / 255f, 249 / 255f);
				break;
			}
			case 2:
			{  	blackup.GetComponent<Renderer>().material.color = new Color (33/255f,150/255f,243/255f);
				blackdown.GetComponent<Renderer>().material.color = new Color (33/255f,150/255f,243/255f);
				col=new Color (33/255f,150/255f,243/255f);
				break;
			}
			case 3:
			{  	blackup.GetComponent<Renderer>().material.color = new Color(10/255f,58/255f,94/255f); 
				blackdown.GetComponent<Renderer>().material.color = new Color(10/255f,58/255f,94/255f); 
				col=new Color(10/255f,58/255f,94/255f); 
				break;
			}
			case 4:
			{  	blackup.GetComponent<Renderer>().material.color = new Color (2/255f,26/255f,43/255f); 
				blackdown.GetComponent<Renderer>().material.color = new Color (2/255f,26/255f,43/255f); 
				col=new Color (2/255f,26/255f,43/255f); 
				break;
			}
			}
			Vector3 spawnPositionup = new Vector3 (200, 94f-l*4, 0);
			Quaternion spawnRotation = new Quaternion ();
			Vector3 spawnPositiondown = new Vector3 (200, -115-l*4 , 0);
			Vector3 spawnposcollectetable=new Vector3(200, ((-94.0f-l)+(115.0f+l))/2,0);
			Quaternion spawnRotationi = new Quaternion (0, 0, 180, 0);
			yield return new WaitForSeconds (8.0f);
			y1=spawnPositiondown.y;
			y2=spawnPositionup.y;
			Instantiate (blackup, spawnPositionup, spawnRotation);
			Instantiate(collectable,spawnposcollectetable,spawnRotation);
			Instantiate (blackdown, spawnPositiondown, spawnRotationi);
		}
	}
/**********************************************************************************/
	IEnumerator spawnboost()
	{
		while (true) 
		{
			Vector3 boostspawnposition = new Vector3 (200, Random.Range (54, -65), 0);

			Quaternion spawnRotation = new Quaternion ();
			yield return new WaitForSeconds (Random.Range(15,30));
			Instantiate (boost, boostspawnposition, spawnRotation);
				
		}
	}
}
