using UnityEngine;
using System.Collections;

public class shadeIncrement : MonoBehaviour {

	public GameObject player,shade1,shade2,shade3,shade4,self;
	public GameObject budaga;
	public static int count;
	public int fourtest=0;
	public int tempsize;
	void Start()
	{
		count = 4;
		player.GetComponent<Renderer>().material.color = new Color(167/255f,224/255f,253/255f); 
		player.GetComponent<Renderer>().sortingLayerName = "4";
	}
	void OnMouseDown()
	{
		Vector3 spawnPosition = new Vector3 (Random.Range(-130.0f,120.0f), Random.Range(-128.0f,-140.0f), 0.0f);
		Quaternion spawnRotation = new Quaternion ();
		budaga.GetComponent<Rigidbody2D>().gravityScale = Random.Range (-0.15f, -0.25f);
		tempsize = Random.Range (3, 7);
		budaga.transform.localScale = new Vector3 (tempsize,tempsize, 0);
		Instantiate (budaga, spawnPosition, spawnRotation);
		if (PlayerPrefs.GetInt ("showinstructions") == 1) 
		{	
			shadeDecrement.slide1_touch_limit+=1;
		}
		count = count + 1;
		if (count >= 4) {
			count = 4;
		}
		switch (count)
		{
		case 4:
		{
			player.GetComponent<Renderer>().material.color = new Color (144/255f,202/255f,249/255f); 
			count=4;
			player.GetComponent<Renderer>().sortingLayerName = "4";
			shade1.GetComponent<Collider2D>().isTrigger=false;
			shade2.GetComponent<Collider2D>().isTrigger=true;
			shade3.GetComponent<Collider2D>().isTrigger=true;
			shade4.GetComponent<Collider2D>().isTrigger=true;
			break; 
		}
		case 3:
		{
			player.GetComponent<Renderer>().material.color = new Color (33/255f,150/255f,243/255f); 
			count=3;
			player.GetComponent<Renderer>().sortingLayerName = "3";
			shade2.GetComponent<Collider2D>().isTrigger=false;
			shade1.GetComponent<Collider2D>().isTrigger=true;
			shade3.GetComponent<Collider2D>().isTrigger=true;
			shade4.GetComponent<Collider2D>().isTrigger=true;
			break;
		}
		case 2:
		{

			player.GetComponent<Renderer>().material.color = new Color (10/255f,58/255f,94/255f); 
			count=2;
			player.GetComponent<Renderer>().sortingLayerName = "2";
			shade3.GetComponent<Collider2D>().isTrigger=false;
			shade2.GetComponent<Collider2D>().isTrigger=true;
			shade1.GetComponent<Collider2D>().isTrigger=true;
			shade4.GetComponent<Collider2D>().isTrigger=true;
			break;
		}
		case 1:
		{
			if(fourtest==0)
			{
			
				fourtest=1;
			}
			player.GetComponent<Renderer>().material.color = new Color (2/255f,26/255f,43/255f); 
			count=1;
			player.GetComponent<Renderer>().sortingLayerName = "1";
			shade4.GetComponent<Collider2D>().isTrigger=false;
			shade2.GetComponent<Collider2D>().isTrigger=true;
			shade3.GetComponent<Collider2D>().isTrigger=true;
			shade1.GetComponent<Collider2D>().isTrigger=true;
			break;
		}
		}
	}
}
