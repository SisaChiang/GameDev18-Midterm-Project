using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this script is for win stage, when player collide with the object.
// that has this script attached on , they get to win stage with a text display.
public class FriendsToWin : MonoBehaviour {

	public Text WinTextDisplay;
	public GameObject milkShakeinHand2;
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider activator)
	{
		
		// insert when the player and the milkshake is being enable, then show the text
		if (milkShakeinHand2.activeInHierarchy)
		{
			WinTextDisplay.text = "You Win!";
			
		}
		else
		{
			WinTextDisplay.text = "Can you get us milkshake?";
		}

	}
}
