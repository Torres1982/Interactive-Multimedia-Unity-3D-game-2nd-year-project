using UnityEngine;
using System.Collections;

public class GameWelcome : MonoBehaviour {
	
	public AudioClip ghostSpell;
	
	//play the winner sound
	void Start () {
		audio.PlayOneShot (ghostSpell);
	}
}