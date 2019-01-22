using UnityEngine;
using System.Collections;

public class EaterEffect3 : MonoBehaviour {
	public Rigidbody2D S31,S32,S33,S34,S35;
	public Vector3 movement = new Vector3(0.65f,0.65f,0.0f);
	public float speed=150;
	public static int j=1;
	public  void Update()
	{
		if(j==1)
		{
			StartCoroutine(Down());
			j=0;
		}
	}
	public IEnumerator Down()
	{
		S31.GetComponent<Rigidbody2D>().AddForce (movement  * speed * 1.1F);
		S32.GetComponent<Rigidbody2D>().AddForce (movement  * speed * 1.05F);
		S33.GetComponent<Rigidbody2D>().AddForce (movement  * speed * 0.85F);
		S34.GetComponent<Rigidbody2D>().AddForce (movement  * speed * 0.8F);
		S35.GetComponent<Rigidbody2D>().AddForce (movement  * speed * 0.9F);
		yield return new WaitForSeconds(1f);
	}
}
