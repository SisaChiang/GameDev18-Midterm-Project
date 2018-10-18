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
	public GameObject FoodinHand2;
	public GameObject NoodleinHand2;
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider activator)
	{
		
		// insert when the player and the milkshake is being enable, then show the text
		if (milkShakeinHand2.activeInHierarchy)
		{
			WinTextDisplay.text = "Thank you!, Press 'M' to win!!";
		}
			
		else
		{
			WinTextDisplay.text = "Can you get us milkshake?";
		}

		if (OtherinHand2.activeInHierarchy)
		{
			WinTextDisplay.text = "Oh, thanks, but this is not the one we want, we want pink milkshake";
		}

		if (FoodinHand2.activeInHierarchy)
		{
			WinTextDisplay.text = "This is not milk shake \n can we have milk shake?";
		}

		if (NoodleinHand2.activeInHierarchy)
		{
			WinTextDisplay.text = "This is ramen... milk shake, please";
		}

	}
}
