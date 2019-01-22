using UnityEngine;
using System.Collections;

public class play_game_music : MonoBehaviour {
	public AudioSource gamemusic;
	public AudioSource mainmusic;
	void Start()
	{
		mainmusic.Play ();
		gamemusic.Pause ();
	}
	void Update()
	{
		if (set_play.musictoplay == 1)
		{
			playgamemusic();
		}
		if (set_play.musictoplay == 2) 
		{
			playmainmusic();
		}
	}
	void playgamemusic()
	{
		mainmusic.Pause ();
		gamemusic.Play ();
		set_play.musictoplay = 4;
	}
	void playmainmusic()
	{
		gamemusic.Pause ();
		mainmusic.Play ();
		set_play.musictoplay = 4;
	}
}
