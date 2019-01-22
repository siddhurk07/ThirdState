using UnityEngine;
using System.Collections;

public class shadeDecrement : MonoBehaviour {
	public GameObject player, shade1, shade2, shade3, shade4,self,budaga;
	public static bool colcheck = false;
	public static int slide1_touch_limit=0;
	void OnMouseDown()
	{
		Vector3 spawnPosition = new Vector3 (Random.Range(-125.0f,120.0f), Random.Range(-118.0f,-140.0f), 0.0f);
		Quaternion spawnRotation = new Quaternion ();
		budaga.GetComponent<Rigidbody2D>().gravityScale = Random.Range (-0.15f, -0.25f);
		Instantiate (budaga, spawnPosition, spawnRotation);
		if (PlayerPrefs.GetInt ("showinstructions") == 1) 
		{
			slide1_touch_limit+=1;
		}
		shadeIncrement.count= shadeIncrement.count - 1;
		if (shadeIncrement.count <= 1) 
		{
			shadeIncrement.count = 1;
		}
		switch (shadeIncrement.count){
		case 4:
		{

			player.GetComponent<Renderer>().material.color = new Color (144/255f,202/255f,249/255f); 
			shadeIncrement.count=4;
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
			shadeIncrement.count=3;
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
			shadeIncrement.count=2;
			player.GetComponent<Renderer>().sortingLayerName = "2";
			shade3.GetComponent<Collider2D>().isTrigger=false;
			shade2.GetComponent<Collider2D>().isTrigger=true;
			shade1.GetComponent<Collider2D>().isTrigger=true;
			shade4.GetComponent<Collider2D>().isTrigger=true;
			break;
		}
		case 1:
		{
			player.GetComponent<Renderer>().material.color = new Color (2/255f,26/255f,43/255f); 
			shadeIncrement.count=1;
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



