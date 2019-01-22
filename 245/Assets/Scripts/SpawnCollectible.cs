using UnityEngine;
using System.Collections;
public class SpawnCollectible : MonoBehaviour {
	public GameObject[] collectibles;
	public GameObject[] pivots;
	public int[] num;
	int range1,range2;
	public static int j;
	public static int low=0,high=18;
	public static int count=0,CountCollectible,Check;
	public void Update()
	{
		if (j == 1) 
		{
			Spawn ();
			j = 0;
		}
	}
	public void Spawn()
	{
		if(CountCollectible > 0 )
		{
				range1 = Random.Range (0, 4);
				Vector3 spawnPosition = new Vector3 ();
				spawnPosition = pivots [range1].transform.position;
				a:
				range2 = Random.Range (low,high);
				count = 0;
				for(int i=0;i<=9;i++)
				{
					if(num[i] == range2)
					{	
						count=1;
						break;
					}
				}
				if (count == 0)
				{
					Instantiate (collectibles [range2], spawnPosition, Quaternion.identity);
					num[9]=num[8];
					num[8]=num[7];
					num[7]=num[6];
					num[6]=num[5];
					num[5]=num[4];
					num[4]=num[3];
					num[3]=num[2];
					num[2]=num[1];
					num[1]=num[0];
					num[0]= range2;
				}
				else 
				{
					goto a;
				}
			if(Check > 0)
			{
				Check--;
				if(Check==0)
				{
					low = 0;
					high = 21;
				}
			}
			if(range2 != 13 || range2 != 14 || range2 != 21)
			{
				CountCollectible--;
			}
		}
	}
}
