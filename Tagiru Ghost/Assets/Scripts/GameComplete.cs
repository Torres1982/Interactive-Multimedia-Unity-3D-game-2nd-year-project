using UnityEngine;
using System.Collections;

public class GameComplete : MonoBehaviour {
	
	public AudioClip fanfare;
	
	//play the winner sound
	void Start () {
		audio.PlayOneShot (fanfare);
	}
}