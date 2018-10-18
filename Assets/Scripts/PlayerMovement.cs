using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Usage: put his on a Capsule with a Rigidbody
// this Script does mouse look and WASD movement for a player

public class PlayerMovement : MonoBehaviour
{

	public float moveSpeed = 1f;
	public GameObject milkShakeinHand;
	public GameObject OtherinHand;
	public GameObject FoodinHand;
	public GameObject NoodleinHand;
	
	// this variable will remember input and pass it to physics
	private Vector3 inputVector;
	
	// degrees for looking up/down, stored as a float so we can clamp it later
	float verticalLook = 0f;
	
	// Update is called once per frame
	void Update () {
		
		// for mouse look

		float mouseX = Input.GetAxis("Mouse X")* Time.deltaTime *100f;
		float mouseY = Input.GetAxis("Mouse Y")* Time.deltaTime *100f;
		
		//rotate camera based on mouse input

		transform.Rotate(0f, mouseX, 0f);
		//Camera.main.transform.Rotate(-mouseY, 0f, 0f);

		//Better Mouse Look
		verticalLook += -mouseY;
		verticalLook = Mathf.Clamp(verticalLook, -80f, 80f);
		
		// actually apply vertical look to the rotation
		Camera.main.transform.localEulerAngles = new Vector3( verticalLook, 0f, 0f);


		// lock and hide the mouse cursor, if they click their mouse
		if (Input.GetMouseButtonDown(0))
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false; // hide it manually
		}



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
			// the game object that tag "milkShakeinHand will be set active = show up in scene"
			// other things other than milkshakeinhand will be disappeared and replaced
			milkShakeinHand.SetActive(true);
			OtherinHand.SetActive(false);
			FoodinHand.SetActive(false);
			NoodleinHand.SetActive(false);
		}

		if (other.gameObject.CompareTag("NotMilkShake"))
		{
			// the game object that tag "OtherinHand" will be set active = show up in scene
			//same with above
			OtherinHand.SetActive(true);
			milkShakeinHand.SetActive(false);
			FoodinHand.SetActive(false);
			NoodleinHand.SetActive(false);
		}

		if (other.gameObject.CompareTag("OtherFood"))
		{
			// the game object that tag "otherfood" will be set active = show up in scene
			// same with above
			FoodinHand.SetActive(true);
			milkShakeinHand.SetActive(false);
			OtherinHand.SetActive(false);
			NoodleinHand.SetActive(false);
		}

		if (other.gameObject.CompareTag("Noodles"))
		{
			// same with all above
			NoodleinHand.SetActive(true);
			FoodinHand.SetActive(false);
			milkShakeinHand.SetActive(false);
			OtherinHand.SetActive(false);
		}
	}

}
