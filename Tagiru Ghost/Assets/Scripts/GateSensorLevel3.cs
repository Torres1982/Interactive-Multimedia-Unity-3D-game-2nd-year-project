using UnityEngine;
using System.Collections;

public class GateSensorLevel3 : MonoBehaviour {

	public Animator animator;
	public PlayerLevel3 player;
			
	//when the player hits the invisible collider, the gate is opening
	void OnTriggerEnter (Collider hit) {
		if (player.IsCarryingAxe()) {
			if (hit.CompareTag ("Player")) {
				animator.SetTrigger ("Open");
				player.ReleaseAxe ();
			}
		}
	}
}
