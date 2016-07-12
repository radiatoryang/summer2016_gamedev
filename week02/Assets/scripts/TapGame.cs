using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class TapGame : MonoBehaviour {

	public Text myTextThing;

	int currentPoints = 0;
	
	// Update is called once per frame
	void Update () {
		// give player 1 point if they press Space
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			currentPoints += 1;
			myTextThing.text = "CURRENT SCORE: " + currentPoints.ToString();
		}

	}
}
