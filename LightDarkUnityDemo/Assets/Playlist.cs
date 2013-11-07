using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Playlist : MonoBehaviour
{
	public List<AudioClip> musicPlaylist = new List<AudioClip>();
	
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (!audio.isPlaying)
		{
			playRandomSong();
		}
	}
	
	private void playRandomSong()
	{
		audio.clip = musicPlaylist[Random.Range(0, musicPlaylist.Count)];
		audio.Play();
	}
}
