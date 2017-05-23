using UnityEngine;
using System.Collections;

public class RampSensorLevel3 : MonoBehaviour {

	public Animator animator;
	public PlayerLevel3 player;
	public AudioClip electric;

	//when the player hits the invisible collider, the ramp is openning
	void OnTriggerEnter (Collider hit) {
		if (player.IsCarryingAxe ()) {
			if (hit.CompareTag ("Player")) {
				animator.SetTrigger ("Open");
				audio.PlayOneShot (electric);
				player.ReleaseAxe ();
			}
		}
	}

	//when the player exits the collider, the ramp is hiding underground
/*	void OnTriggerExit (Collider hit) {
		if (hit.CompareTag ("Player")) {
			animator.SetTrigger ("Hide");		
		}
	}*/
}
