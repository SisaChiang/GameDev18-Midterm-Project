using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// this script is for win stage, when player collide with the object.
// that has this script attached on , they get to win stage with a scene change.
public class FriendsToWin : MonoBehaviour {

	public Text WinTextDisplay;
	public GameObject milkShakeinHand2;
	public GameObject OtherinHand2;
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider activator)
	{
		
		// insert when the player and the milkshake is being enable, then show the text
		if (milkShakeinHand2.activeInHierarchy)
		{
			WinTextDisplay.text = "You Win!, Press 'M'";
		}
			
		else
		{
			WinTextDisplay.text = "Can you get us milkshake?";
		}

		if (OtherinHand2.activeInHierarchy)
		{
			WinTextDisplay.text = "Oh, This is not the milk shake we want";
		}

	}
}
