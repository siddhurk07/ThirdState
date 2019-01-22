using UnityEngine;
using System.Collections;

public class Center : MonoBehaviour {
	public GameObject player;
	public GameObject[] pivots;
	public float startTap1,startTap2;
	public float tapTime;
	public int count,flag;
	public void Start()
	{
		count = 1;
		flag = 1;
	}
	public void OnMouseDown()
	{
		if(count == 1)
		{
			startTap1 = Time.time;
			flag = 2;
		}
		if(count == 2)
		{
			tapTime = Time.time - startTap1;
			if(tapTime < 0.3f)
			{
				StartCoroutine(func());
			}
			count = 1;
			flag = 1;
		}
		if(flag == 2)
		{
			count = 2;
		}
	}
	public IEnumerator func()
	{
		if(SpawnPlayer.count == 4 || SpawnPlayer.count == 1)
		{
		SpawnPlayer.GridNo = SpawnPlayer.GridNo + 4;
		player.transform.position = pivots [SpawnPlayer.GridNo].transform.position;
		yield return new WaitForSeconds (0.1f);
		CollectibleScript1.j = 1;
		CollectibleScript2.j = 1;
		CollectibleScript3.j = 1;
		CollectibleScript4.j = 1;
		CollectibleScript5.j = 1;
		CollectibleScript6.j = 1;
		CollectibleScript7.j = 1;
		CollectibleScript8.j = 1;
		CollectibleScript9.j = 1;
		CollectibleScript10.j = 1;
		CollectibleScript11.j = 1;
		CollectibleScript12.j = 1;
		CollectibleScript13.j = 1;
		CollectibleScript14.j = 1;
		CollectibleScript15.j = 1;
		CollectibleScript16.j = 1;
		Bomb1.j=1;
		Bomb2.j=1;
		bomb3.j=1;
		Timer1.j=1;
		Timer2.j=1;
		PowerUp1.j=1;
		PowerUp2.j=1;
		Spare1.j=1;
		Spare2.j=1;
		Spare3.j=1;
		Spare4.j=1;
		Spare5.j=1;
		Spare6.j=1;
		Spare7.j=1;
		SpawnPlayer.GridNo = SpawnPlayer.GridNo - 4;
		while(true)
		{
			player.transform.position = Vector3.MoveTowards(player.transform.position, pivots[SpawnPlayer.GridNo].transform.position,Time.deltaTime * 48f);
			if(player.transform.position ==  pivots[SpawnPlayer.GridNo].transform.position)
			{
				break;
			}
		}
		SpawnCollectible.j = 1;
		}
	}
}
