using UnityEngine;
using System.Collections;

public class DroneTest : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		RaycastHit2D rayHit = Physics2D.Raycast( transform.position, transform.up, 0.1f );
		if ( rayHit.collider != null ) {
			float randomNumber = Random.Range(0f, 2f);
			if ( randomNumber < 1f ) {
				transform.Rotate(0f, 0f, 90f);
			} else {
				transform.Rotate(0f, 0f, -90f);
			}
		} else {
			transform.position += transform.up * Time.deltaTime;
		}

	}
}
