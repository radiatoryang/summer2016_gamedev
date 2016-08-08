using UnityEngine;
using System.Collections;

public class EaseMoveExample : MonoBehaviour {

	public Vector3 original_position;
	public float delta;
	public float duration;
	float timer = 0f;

	// Use this for initialization
	void Start () {
		original_position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		Vector3 target = Vector3.zero;
		// target.x = EaseIn_Exponent( 0f, delta, duration, timer );
		target = EaseIn_Exponent( Vector3.zero, Vector3.one * delta, duration, timer);
		transform.position = original_position + target;
	}

	// from = where the value starts
	// delta = distance you want to travel
	// duration = how long it will take
	// time = usually a value from 0-1
	float EaseIn_Linear(float _from, float _delta, float _duration, float time ) {
		if ( time > _duration) {
			return _from + _delta;
		} else {
			return ( ( time / _duration ) * _delta) + _from;
		}
	}

	float EaseIn_Exponent( float _from, float _delta, float _duration, float time ) {
		if ( time > _duration) {
			return _from + _delta;
		} else {
			return (Mathf.Pow(2f, 10f * ( ( time / _duration ) - 1f )) * _delta ) + _from;
		}
	}

	Vector3 EaseIn_Exponent( Vector3 _from, Vector3 _delta, float _duration, float time ) {
		if ( time > _duration ) { 
			return _from + _delta;
		} else {
			Vector3 toReturn = Vector3.zero;
			for ( int i=0; i<3; i++) {
				toReturn[i] = EaseIn_Exponent( _from[i], _delta[i], _duration, time );
			}
			return toReturn;
		}
	}
}
