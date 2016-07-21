using UnityEngine;
using System.Collections;

public class SoundLoop : MonoBehaviour {

	AudioSource myAudioSource;

	// Use this for initialization
	void Start () {
		myAudioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		// if I press L, then play the sound and loop it
		if ( Input.GetKeyDown(KeyCode.L) ) {
			if ( myAudioSource.isPlaying ) {
				myAudioSource.Stop();
			} else {
				myAudioSource.loop = true;
				myAudioSource.Play();
			}
		}

	}
}
