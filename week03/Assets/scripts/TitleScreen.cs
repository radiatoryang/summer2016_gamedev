using UnityEngine;
using System.Collections;

using UnityEngine.SceneManagement; // we need this line here to load scenes

public class TitleScreen : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// if player pressed space, load scene number 1
		if ( Input.GetKeyDown(KeyCode.Space) ) {
			// number is based on build index in "Build Settings" menu
			SceneManager.LoadScene( 1 );
		}
	}
}
