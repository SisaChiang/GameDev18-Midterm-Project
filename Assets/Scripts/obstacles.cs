using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// this script is when player collide with obstacles
// attach this script to the obstacle objects
//Intent: when collide with the obstacles, timer counts faster



public class obstacles : MonoBehaviour
{

	
	//public Text GameOverText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider activator)
	{
		TIme.timeLeft -= Time.deltaTime * 5f; 
		//Destroy(activator.gameObject);
		//GameOverText.text = "Game Over!";

	}

}
