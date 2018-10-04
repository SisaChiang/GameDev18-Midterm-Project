using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Usage: put this script on Obstacles in the scene
// intent: let Obstacles to move around randomly
public class ObstacleMovement : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		
		// define ray
		Ray ObstacleRay = new Ray(transform.position, transform.forward);
		
		// maximum raycast distance
		float maxRaycastDistance = 1f; 
		
		// visualize the raycast
		Debug.DrawRay( ObstacleRay.origin, ObstacleRay.direction * maxRaycastDistance, Color.green);
		
		// shoot the raycast

		if (Physics.Raycast(ObstacleRay, maxRaycastDistance))
		{
			int randomNumber = Random.Range(0, 100); // rand num from 0- 100
			if (randomNumber < 25)
			{
				// 50 percent chance of turning left
				transform.Rotate(0f, -90f, 0f);
			}
			else if (randomNumber <50)
			{
				// 50 percent chance of turning right
				transform.Rotate(0f, 90f, 0f);
			}
			else if (randomNumber < 75)
			{
				// 50 percent chance of turning forward
				transform.Rotate(90f, 0f, 0f);
			}
			else
			{
				// 50 percent chance of turning back?
				transform.Rotate(-90f, 0f, 0f);
			}
		}
		else
		{
			// if raycast is false = nothing in raycast's way
			transform.Translate(0f,0f, Time.deltaTime);
		}
	
		

	}
}
