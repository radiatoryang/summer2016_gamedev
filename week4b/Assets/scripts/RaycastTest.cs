using UnityEngine;
using System.Collections;

public class RaycastTest : MonoBehaviour {

	public GameObject laserBeam;
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(0f, 0f, -Input.GetAxis("Horizontal") * Time.deltaTime * 360f );

		if ( Input.GetKey(KeyCode.Space) ) {
			laserBeam.SetActive(true);

			RaycastHit2D raycastHit = Physics2D.Raycast( transform.position, transform.up, 100f);

			if ( raycastHit.collider != null ) {
				Destroy( raycastHit.collider.gameObject );
			}
		} else {
			laserBeam.SetActive(false);
		}
	}
}
