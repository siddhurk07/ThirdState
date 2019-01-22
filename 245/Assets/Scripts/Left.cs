using UnityEngine;
using System.Collections;

public class Left : MonoBehaviour {
	public GameObject player;
	public GameObject[] pivots;
	public IEnumerator OnMouseDown()
	{
		if(SpawnPlayer.count != 1)
		{
			SpawnPlayer.GridNo = SpawnPlayer.GridNo + 3;
			player.transform.position = pivots [SpawnPlayer.GridNo].transform.position;
			SpawnPlayer.count--;
			yield return new WaitForSeconds(0.1f);
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
			Bomb1.j = 1;
			Bomb2.j = 1;
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
			SpawnCollectible.j=1;
		}
		else
		{
			SpawnPlayer.GridNo = SpawnPlayer.GridNo + 7;
			Teleport.j=2;
			player.transform.position = pivots [SpawnPlayer.GridNo].transform.position;
			SpawnPlayer.count = 4;
			yield return new WaitForSeconds(0.1f);
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
			Bomb1.j = 1;
			Bomb2.j = 1;
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
			SpawnCollectible.j=1;
		}
	}
}
