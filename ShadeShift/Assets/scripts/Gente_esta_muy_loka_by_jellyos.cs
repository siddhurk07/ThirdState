using UnityEngine;
using System.Collections;

public class Gente_esta_muy_loka_by_jellyos : MonoBehaviour {
	public GameObject we;
	public int displaycount;
	void OnMouseDown()
	{
		displaycount += 1;
		if(displaycount >= 5)
		{
            we.SetActive(true);
			displaycount=0;
		}
	}
}
