using UnityEngine;
using System.Collections;

public class EnemyNavigation : MonoBehaviour {

	private NavMeshAgent navMeshAgent;
	private GameObject player;

	private bool followPlayer = false;

	//get reference to the player and nav mesh agent
	void Start () {	
		navMeshAgent = GetComponent<NavMeshAgent> ();
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	public void SetFollowingPlayer (bool newFollowPlayer) {
			followPlayer = newFollowPlayer;
			//stopping and moving Tagiru Enemy
			if (followPlayer) {
				navMeshAgent.Resume ();		
			}
			else {
				navMeshAgent.Stop ();	
			}
	}

	// Update enemy target position to be the current position
	void Update () {
		if (followPlayer) {
			Vector3 playerPosition = player.transform.position;
			navMeshAgent.SetDestination (playerPosition);
		}
	}
}
