using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// this script is when player collide with obstacles
// the player object will be destroyed and lead to game over
// attach this script to the obstacle objects

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
		Destroy(activator.gameObject);

		//GameOverText.text = "Game Over!";
	}

}
