using UnityEngine;
using System.Collections;

public class Back : MonoBehaviour {
	public GameObject Bichapp;
	void OnMouseDown()
	{
		Bichapp.SetActive (false);
	}
}
