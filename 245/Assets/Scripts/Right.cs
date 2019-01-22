using UnityEngine;
using System.Collections;
public class Right : MonoBehaviour {
	public GameObject player,teleportR1,receiverL1;
	public GameObject[] pivots;
	public IEnumerator OnMouseDown()
	{
		if (SpawnPlayer.count != 4) 
		{
			SpawnPlayer.GridNo = SpawnPlayer.GridNo + 5;
			player.transform.position = pivots [SpawnPlayer.GridNo].transform.position;
			SpawnPlayer.count++;
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
			SpawnPlayer.GridNo = SpawnPlayer.GridNo + 1;
			Teleport.j=1;
			player.transform.position = pivots [SpawnPlayer.GridNo].transform.position;
			SpawnPlayer.count = 1;
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
