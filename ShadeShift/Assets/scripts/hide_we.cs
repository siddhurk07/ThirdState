using UnityEngine;
using System.Collections;

public class hide_we : MonoBehaviour {

	public GameObject self;
	void OnMouseDown()
	{
		self.SetActive (false);
	}
}
