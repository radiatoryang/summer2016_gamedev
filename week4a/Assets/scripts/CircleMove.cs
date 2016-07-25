using UnityEngine;
using System.Collections;

public class CircleMove : MonoBehaviour {

	public Transform destination;
	
	// Update is called once per frame
	void Update () {
		// "stopping distance"... only move if we are more than 0.25 units away
		if ( Vector3.Distance( transform.position, destination.position ) > 0.25f ) {
			// multiplying by Time.deltaTime makes a behavior framerate independent
			transform.position += Vector3.Normalize(destination.position - transform.position) 
								  * Time.deltaTime;
		}
	}

	void OnDrawGizmos () {
		// will draw a line inside the scene view
		Gizmos.DrawLine( transform.position, destination.position );
	}

}
