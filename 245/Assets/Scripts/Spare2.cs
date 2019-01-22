using UnityEngine;
using System.Collections;

public class Spare2 : MonoBehaviour {
	public static int j;
	public GameObject collections;
	public GameObject[] pivots;
	public void Update()
	{
		if(j==1)
		{
			StartCoroutine(Down());
			j=0;
		}
	}
	public IEnumerator Down()
	{
		for (int j=0; j<28; j++) 
		{
			if (collections.transform.position == pivots [j].transform.position) 
			{
				if(j<8 || j>27)
				{
					collections.layer = 8;
					collections.gameObject.tag = "ob6";
				}
				if(j<4)
				{
					while(true)
					{
						collections.transform.position = Vector3.MoveTowards(collections.transform.position,pivots[j+28].transform.position,Time.deltaTime * 42f);
						if(collections.transform.position == pivots[j+28].transform.position)
						{
							break;
						}
						yield return null;
					}
					break;
				}
				while(true)
				{
					collections.transform.position = Vector3.MoveTowards(collections.transform.position,pivots[j-4].transform.position,Time.deltaTime * 42f);
					if(collections.transform.position == pivots[j-4].transform.position)
					{
						break;
					}
					yield return null;
				}
				break;
			}
		}
	}
}
