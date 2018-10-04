using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Usage: put his on a Capsule with a Rigidbody
// this Script does mouse look and WASD movement for a player

public class PlayerMovement : MonoBehaviour
{

	public float moveSpeed = 1f;
	public GameObject milkShakeinHand;
	
	// this variable will remember input and pass it to physics
	private Vector3 inputVector;
	
	// Update is called once per frame
	void Update () {
		
		// for mouse look

		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = Input.GetAxis("Mouse Y");
		
		//rotate camera based on mouse input

		transform.Rotate(0f, mouseX, 0f);
		Camera.main.transform.Rotate(-mouseY, 0f, 0f);
		
		// WASD movement
		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");
		
		// apply keyboard input to position
		inputVector = transform.forward * vertical;
		inputVector += transform.right * horizontal;
		
		

	}

	void FixedUpdate()
	{
		GetComponent<Rigidbody>().velocity = inputVector * moveSpeed + Physics.gravity * 0.5f;
	}

	void OnTriggerEnter(Collider other)
	{
		// when player collide with the game object that tagged "Milkshake"
		if (other.gameObject.CompareTag("MilkShake"))
		{
			// the game object "milkShakeinHand will be set active = show up in scene"
			milkShakeinHand.SetActive(true);
		}
	}

}
