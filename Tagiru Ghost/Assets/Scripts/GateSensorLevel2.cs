using UnityEngine;
using System.Collections;

public class GateSensorLevel2 : MonoBehaviour {

	public GameObject gate;
	public PlayerLevel2 player;
	
	//when colliding with the gate - open the gate
	void OnTriggerEnter (Collider hit) {
		if (hit.CompareTag ("Player")) {
			if (player.IsCarryingAxe()) {
				Destroy (gate);
				player.ReleaseAxe ();
			}
		}
	}
}
