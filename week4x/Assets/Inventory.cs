using UnityEngine;
using System.Collections;

using UnityEngine.UI;

public class Inventory : MonoBehaviour {

	public int currentGold = 5;

	public Button buttonPrefab;
	public Transform buttonParent;

	public Sprite[] possibleItemSprites;

	void Start () {
		// 1st part of for loop: initialize stuff (usually, a counter var)
		// 2nd part: the condition to keep checking... if false, the for() will end
		// 3rd part: what to do at the end of a loop cycle (usually, increment)
		for ( int count=0; count<50; count+=1 ) { // run 50 times
			// let's generate some random values for our item
			// - random item sprite
			Sprite randomSprite = possibleItemSprites[ Random.Range(0, possibleItemSprites.Length) ];
			// - random gold value
			int randomGoldValue = Random.Range(0, 100);

			Button myNewButton = (Button)Instantiate( buttonPrefab, buttonPrefab.transform.position, buttonPrefab.transform.rotation );

			// set button sprite to the random sprite we selected earlier
			myNewButton.image.sprite = randomSprite;
			// change the listed gold value on the Text UI of the clone
			myNewButton.GetComponentInChildren<Text>().text = randomGoldValue.ToString();

			// set the clone's parent to the canvas
			myNewButton.transform.SetParent( buttonParent );

			// add events back onto the button
			myNewButton.onClick.RemoveAllListeners(); // clean it up
			myNewButton.onClick.AddListener( 
				delegate { // a delegate is where you treat a function like a variable
					SellItem( randomGoldValue ); 
				} 
			);
			myNewButton.onClick.AddListener( 
				delegate { 
					DeleteItem( myNewButton.gameObject );
				} 
			);

		}

	}
		

	// if you want any UI control to be able to call a function
	// then that function *MUST BE* "public void"
	public void SellItem( int itemGoldValue ) {
		currentGold += itemGoldValue;

		// these two lines do basically the same thing

//		Debug.Log("sold item for " + itemGoldValue.ToString() + " ... now have " 
//			+ currentGold.ToString() + " total" );
		
		Debug.Log( string.Format( "sold item for {0}, now have {1} total gold",
			itemGoldValue, currentGold) );
	}

	public void DeleteItem (GameObject thisItem) {
		Destroy( thisItem );
	}
}
