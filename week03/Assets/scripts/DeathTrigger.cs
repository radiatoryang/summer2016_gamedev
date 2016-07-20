using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {

	public int damage = 1;

	// a function that is automatically called when
	// AS LONG AS a thing stays in the trigger, each frame
	void OnTriggerStay2D( Collider2D activator ) {
		// does the activating thing have a Killable script on it?
		if ( activator.GetComponent<Killable>() != null ) {
			activator.GetComponent<Killable>().Hurt( damage );
		}
	}

	// a function that is automatically called when
	// something with a Rigidbody2D enters this trigger
	void OnTriggerEnter2D( Collider2D activator ) {
		// does the activating thing have a Killable script on it?
		if ( activator.GetComponent<Killable>() != null ) {
			// TODO: subtract health from the Killable script

			// destroy this object
			// Destroy( activator.gameObject );
		}
	}

}
