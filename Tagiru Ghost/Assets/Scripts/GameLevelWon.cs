using UnityEngine;
using System.Collections;

public class GameLevelWon : MonoBehaviour {

	public AudioClip winner;

	//play the winner sound
	void Start () {
		audio.PlayOneShot (winner);
	}
}