using UnityEngine;
using System.Collections;

public class SquareMoveCursor : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// "ScreenToWorldPoint" converts your mouse cursor's pixel coordinate to a 3D world coordinate
		Vector3 cursorPositionInWorld = Camera.main.ScreenToWorldPoint( Input.mousePosition );

		// set the "Z" of the WorldPoint to 0 so that our camera can see it
		cursorPositionInWorld.z = 0f; // this WORKS
		// transform.position.z = 0f; // this DOES NOT work

		// 0 = left-click, 1 = right-click, 2 = middle-click, 3 = your gamer mouse buttons
		if ( Input.GetMouseButtonDown(0) ) {
			// teleport this gameObject to where our cursor is
			transform.position = cursorPositionInWorld;
		}
	}
}
