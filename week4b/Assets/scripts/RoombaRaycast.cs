using UnityEngine;
using System.Collections;

public class RoombaRaycast : MonoBehaviour {

	void Update () {
		// let's shoot a very short small raycast in front of us
		RaycastHit2D roombaHit = Physics2D.Raycast( transform.position, transform.up, 0.2f);
		// if the raycast hit something...
		if ( roombaHit.collider != null ) {
			// turn randomly 90 degrees left or right
			float randomNumber = Random.Range(0f, 1f);
			if ( randomNumber > 0.5f ) { // 50% chance to turn left
				transform.Rotate(0f, 0f, 90f);
			} else {
				transform.Rotate(0f, 0f, -90f);
			}
		} else { // if the raycast hit NOTHING...
			// always go "forward" along it's local Up direction
			transform.position += transform.up * Time.deltaTime;
		}
	}
}
