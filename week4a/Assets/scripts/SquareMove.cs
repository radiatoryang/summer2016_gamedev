using UnityEngine;
using System.Collections;

public class SquareMove : MonoBehaviour {

	public float mouseMoveSpeed = 5f;
	
	// Update is called once per frame
	void Update () {
		// Input.GetAxis() usually returns a value between -1 and 1
		float horizontal = Input.GetAxis("Mouse X");
		float vertical = Input.GetAxis("Mouse Y");

		// actually apply mouseDelta to square position now
		transform.position += new Vector3( horizontal, vertical, 0f ).normalized 
							  * Time.deltaTime * mouseMoveSpeed;
	}
}
