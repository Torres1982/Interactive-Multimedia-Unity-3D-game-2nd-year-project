using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {
	
	public AudioClip sad;
	
	//play the winner sound
	void Start () {
		audio.PlayOneShot (sad);
	}
}