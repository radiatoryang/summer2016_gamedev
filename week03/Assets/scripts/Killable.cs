using UnityEngine;
using System.Collections;

public class Killable : MonoBehaviour {

	public int maxHealth = 100;
	public int currentHealth;

	// Use this for initialization
	void Start () {
		// everyone starts with 100% health at the beginning of the game
		currentHealth = maxHealth; 
	}

	// notice we made this a PUBLIC function; that's so DeathTrigger can use it
	public void Hurt (int damage) {
		currentHealth -= damage;
		currentHealth = Mathf.Clamp( currentHealth, 0, maxHealth );

		// destroy myself if my health is less than or equal to 0
		if ( currentHealth <= 0 ) {
			Destroy( gameObject );
		}
	}
}
