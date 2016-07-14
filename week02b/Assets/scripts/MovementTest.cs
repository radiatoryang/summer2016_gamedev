using UnityEngine;
using System.Collections;

public class MovementTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKey(KeyCode.W) ) {
//			transform.position += new Vector3(0f, 5f, 0f) * Time.deltaTime;
//		}

		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		if (Input.GetKey(KeyCode.W) ) {
			GetComponent<Rigidbody2D>().velocity += new Vector2(0f, 5f);
		}
	}
}
