using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Usage: put this on your Player with a Rigidbody
// this script does mouse look and WASD movement for a player
public class PlayerMovement : MonoBehaviour
{

	public float moveSpeed = 1f;
	
	// this variable will remember input and pass it to physics
	private Vector3 inputVector;


	// Update is called once per frame
	void Update () {
		
		
		// for mouse look 
		float mouseX = Input.GetAxis("Mouse X"); // horizontal mouse movement
		float mouseY = Input.GetAxis("Mouse Y"); // vertical mouse movement
		
		// rotate camera based on mouse input
		// first, rotate body based on horizontal mouse movement
		transform.Rotate(0f, mouseX, 0f);
		Camera.main.transform.Rotate( -mouseY, 0f, 0f);
		
		// WASD movement
		float horizontal = Input.GetAxis("Horizontal"); // A/D, Left/Right
		float vertical = Input.GetAxis("Vertical");
		
		// apply keyboard input to position in a better way

		inputVector = transform.forward * vertical;
		inputVector += transform.right * horizontal;
	}

	private void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = inputVector * moveSpeed + Physics.gravity * 0.5f;
	}
}
