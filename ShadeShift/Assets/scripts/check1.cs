using UnityEngine;
using System.Collections;

public class check1 : MonoBehaviour {
	public GameObject self,player;
	void Update () 
	{
		if (player.GetComponent<Renderer>().sortingLayerName == self.GetComponent<Renderer>().sortingLayerName) 
		{
			self.GetComponent<Collider2D>().isTrigger = false;
		} else
		{
			self.GetComponent<Collider2D>().isTrigger = true;
		}
		if (player.transform.position.x > self.transform.position.x + 200 && self.transform.position.y == -14.43f) 
		{
			Destroy(self);
		}
	}
}
