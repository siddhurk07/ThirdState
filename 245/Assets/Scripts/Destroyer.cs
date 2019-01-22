using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	public void OnCollisionEnter2D(Collision2D other)
	{
		Destroy(other.gameObject);
	}
}
