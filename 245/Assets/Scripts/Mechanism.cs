using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Mechanism : MonoBehaviour {
	public GameObject[] Numbers;
	public GameObject Player;
	public	void OnCollisionEnter2D( Collision2D other)
	{
		if(other.gameObject.tag == "3")
		{
		   Destruct.GameValue = Destruct.GameValue + Destruct.Mul*3;
	       Destroy (other.gameObject);
		}
		else if(other.gameObject.tag == "4")
		{
			Destruct.GameValue = Destruct.GameValue + Destruct.Mul*4;
			Destroy (other.gameObject);
		}
		else if(other.gameObject.tag == "5")
		{
			Destruct.GameValue = Destruct.GameValue + Destruct.Mul*5;
			Destroy (other.gameObject);
		}
		else if(other.gameObject.tag == "6")
		{
		   Destruct.GameValue = Destruct.GameValue + Destruct.Mul*6;
		   Destroy (other.gameObject);
		}
		else if (other.gameObject.tag == "PowerUP")
		{
			SpawnCollectible.low = 22;
			SpawnCollectible.high = 28;
			SpawnCollectible.Check = 5;
			Destroy (other.gameObject);
		}
		else if (other.gameObject.tag == "Timer")
		{
			if(Destruct.check1 == 1)
			{
				Destruct.Timer =Destruct.Timer + 5;
			}
			else
			{
				Destruct.Timer =Destruct.Timer - 5;
			}
			Destroy(other.gameObject);
		}
		else if(other.gameObject.tag =="bomb")
		{
			if(Destruct.GameValue % 2==0)
			{
				Destruct.GameValue = Destruct.GameValue/2;
			}
			else
			{
				Destruct.GameValue -= 1;
				Destruct.GameValue = Destruct.GameValue/2;
			}
			Destroy (other.gameObject);
		}
	}
}
