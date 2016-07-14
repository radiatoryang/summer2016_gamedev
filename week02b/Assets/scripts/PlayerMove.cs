using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		// if the player holds down W, move up
		if ( Input.GetKey( KeyCode.W ) ) {
			// Time.deltaTime is the duration of the frame in seconds
			// if your FPS is 10 FPS, then deltaTime would be 0.1f
			// if your FPS is 100 FPS, then deltaTime would be 0.01f
			// this is now "Framerate independent"
			transform.position += new Vector3( 0f, 5f, 0f ) * Time.deltaTime;
			Debug.Log( transform.position.y ); // reading the Y is ok
		}

		if ( Input.GetKey( KeyCode.A ) ) {
			transform.position += new Vector3( -5f, 0f, 0f ) * Time.deltaTime;
		}

		if ( Input.GetKey( KeyCode.S ) ) {
			transform.position += new Vector3( 0f, -5f, 0f ) * Time.deltaTime;
		}

		if ( Input.GetKey( KeyCode.D ) ) {
			transform.position += new Vector3( 5f, 0f, 0f ) * Time.deltaTime;
		}

	}

}
