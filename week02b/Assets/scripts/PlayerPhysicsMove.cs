using UnityEngine;
using System.Collections;

public class PlayerPhysicsMove : MonoBehaviour {

	// Update is where rendering and input update
	// FixedUpdate is called once per PHYSICS FRAME
	void FixedUpdate () {
		// reset velocity every frame
		GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f); 

		// press W to apply upward force
		if ( Input.GetKey(KeyCode.W) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2( 0f, 50f ) * Time.deltaTime;
		}

		if ( Input.GetKey(KeyCode.A) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2( -50f, 0f ) * Time.deltaTime;
		}
		if ( Input.GetKey(KeyCode.S) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2( 0f, -50f ) * Time.deltaTime;
		}
		if ( Input.GetKey(KeyCode.D) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2( 50f, 0f ) * Time.deltaTime;
		}

	}
}
