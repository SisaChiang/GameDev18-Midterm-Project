using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// this script is when player collide with obstacles
// attach this script to the obstacle objects
//Intent: when collide with the obstacles, timer counts faster



public class obstacles : MonoBehaviour
{

	public TIme gameTimer;
	// set a public float that the time.delta time can * with so it can gets faster
	public float FasterTime = 5f;
	
	//public Text GameOverText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// when player is Staying (Or in) the Trigger 
	void OnTriggerStay(Collider activator)
	{
		// call the timer in the other script, and let it go faster
		gameTimer.timeLeft -= Time.deltaTime * FasterTime ; 

	}

}
