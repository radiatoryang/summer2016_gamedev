using UnityEngine;
using System.Collections;

public class LookAtCursor2D : MonoBehaviour {

	public Transform player;
	
	// Update is called once per frame
	void Update () {
		Vector3 cursorWorldPos = Camera.main.ScreenToWorldPoint( Input.mousePosition );
		cursorWorldPos.z = 0f;
		Vector3 lineFromPlayerToCursor = cursorWorldPos - player.position;

		player.up = lineFromPlayerToCursor;
	}
}
