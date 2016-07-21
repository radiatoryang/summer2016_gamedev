using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartButton : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		// press R to restart the current scene
		if ( Input.GetKeyDown(KeyCode.R) ) {
			int currentSceneNumber = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene( currentSceneNumber );
		}
	}
}
