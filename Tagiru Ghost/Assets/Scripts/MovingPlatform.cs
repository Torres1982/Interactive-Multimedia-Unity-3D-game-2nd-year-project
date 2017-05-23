using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	//declare variables
	public Transform DestinationSpot;
	public Transform OriginSpot;
	public float Speed;
	public bool Switch = false;

	//checking the position of the moving platform
	void FixedUpdate() {
		if (transform.position == DestinationSpot.position) {
			Switch = true;
		}
		if (transform.position == OriginSpot.position) {
			Switch = false;		
		}
		//tell the platform to move to its origin when Switch is true
		if (Switch) {
			transform.position = Vector3.MoveTowards (transform.position, OriginSpot.position, Speed);		
				}
		//tell the platform to move to its destination when Switch is false
		else {
			transform.position = Vector3.MoveTowards (transform.position, DestinationSpot.position, Speed);		
		}
	}

}
