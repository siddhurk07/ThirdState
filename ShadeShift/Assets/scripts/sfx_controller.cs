using UnityEngine;
using System.Collections;

public class sfx_controller : MonoBehaviour {
	public AudioSource collision_sound;
	public AudioSource boost_sound;
	public static int sfxcollision=0;
	public static int sfxboost=0;
	void Update () 
	{
		if (sfxcollision == 1)
		{
			collision_sound.Play ();
			sfxcollision=2;
		}
		if (sfxboost == 1) 
		{
			boost_sound.Play ();
			sfxboost=2;		
			
		}
	}
}
