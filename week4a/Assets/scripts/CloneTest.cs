using UnityEngine;
using System.Collections;

public class CloneTest : MonoBehaviour {

	public GameObject thingToClone; 
	
	// Update is called once per frame
	void Update () {
		// if I press SPACE...
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			// ... then make a new copy of the thing at a random point
			Instantiate( thingToClone, 
						 new Vector3( Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0f ),
						 Quaternion.Euler(0f, 0f, 0f) );
			// "Euler" refers to 0-360 degree angles
		}
	}
}
