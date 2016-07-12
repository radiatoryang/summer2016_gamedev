using UnityEngine;
using System.Collections;

using UnityEngine.UI; // this line will let your code talk to the Text

public class HelloWorld : MonoBehaviour {

	// declare a Text variable so that this code can talk to it
	public Text myTextObject;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Bonjour Monde");

		myTextObject.text = "Hola Mundo";
	}
}
