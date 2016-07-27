using UnityEngine;
using System.Collections;

public class LaserRaycast : MonoBehaviour {

	public GameObject laserBeamObject;
	
	void Update () {
		// using A/D or Left/Right to rotate the player's circle
		// (for example: if I held [D] for 1 second, it will turn 90 degrees)
		transform.Rotate(0f, 0f, -Input.GetAxis("Horizontal") * Time.deltaTime * 90f );

		if ( Input.GetKey(KeyCode.Space) ) {
			// shooting laser beam!
			laserBeamObject.SetActive(true);

			// actually shoot raycast now
			RaycastHit2D raycastHit = Physics2D.Raycast( transform.position, transform.up, laserBeamObject.transform.localScale.y );

			// let's check the results of the raycast
			if ( raycastHit.collider != null ) {
				Destroy( raycastHit.collider.gameObject ); // destroy the thing it hit
			} 
		} else {
			// NOT shooting laser beam
			laserBeamObject.SetActive(false);
		}

	}
}
