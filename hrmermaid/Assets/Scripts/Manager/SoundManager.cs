using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

	public AudioClip[] songs;
	public AudioSource audioSource;

	// Use this for initialization
	void Start () {

		int randClip = Random.Range (0, songs.Length);
		audioSource.clip = songs[randClip];
		audioSource.Play();
	}
	

}
