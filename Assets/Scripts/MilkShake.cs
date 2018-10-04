using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this script is for win stage, when player collide with the object.
// that has this script attached on , they get to win stage with a text display.
// (MAYBE)should change to different scene in the future.
public class MilkShake : MonoBehaviour
{


	public Text WinTextDisplay;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider activator)
	{
		WinTextDisplay.text = "You Win!";
	}
}
