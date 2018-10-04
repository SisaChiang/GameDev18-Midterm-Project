using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// this script is for my countdown timer
// put this script on a Text display.
public class TIme : MonoBehaviour
{
	public float timeLeft = 300.0f;
	
	public Text myTextDisplay;

	private float myScore = 0f;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{

		timeLeft -= Time.deltaTime;
		myTextDisplay.text = "Time Left: " + Mathf.Round(timeLeft);

		if (timeLeft < 0)
		{
			myTextDisplay.text = "Game Over";
		}



	}
}
