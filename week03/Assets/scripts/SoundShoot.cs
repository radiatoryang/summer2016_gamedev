using UnityEngine;
using System.Collections;

public class SoundShoot : MonoBehaviour {

	// remember: drag and drop to assign in Inspector
	public AudioSource myAudioSource;
	// you can also declare multiple audiosources to remember
	public AudioSource danceSound, shootSound, laughingSound;

	float whenDidILastPressSpacebar = 0f;
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKeyDown(KeyCode.Space) && Time.time - whenDidILastPressSpacebar > 1f) {
			// imagine you had some "shoot laser" code here

			// now, play the Pew Pew sound
			// myAudioSource.Play();
			// possible problem with Play(): it restarts the sound if already playing
		
			// PlayOneShot will play an uninterruptable sound
			// and automatically clean it up when it's done
			myAudioSource.PlayOneShot( myAudioSource.clip );

			whenDidILastPressSpacebar = Time.time;
		}
	}
}
