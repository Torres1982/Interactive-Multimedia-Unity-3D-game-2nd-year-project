using UnityEngine;
using System.Collections;

public class TagiruSensor : MonoBehaviour {

	public EnemyNavigation tagiruEnemy;

	public AudioClip evilLaugh;

	//the enemy follows the character when sensor is hit
	void OnTriggerEnter (Collider hit) {
		if (hit.CompareTag ("Player")) {
			audio.PlayOneShot (evilLaugh);
			tagiruEnemy.SetFollowingPlayer (true);		
		}
	}
	
	//the enemy stops following the character
	void OnTriggerExit (Collider hit) {
		if (hit.CompareTag ("Player")) {
			tagiruEnemy.SetFollowingPlayer (false);		
		}
	}
}
