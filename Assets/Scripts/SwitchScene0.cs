using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SwitchScene0 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// apply this on start scene in order to switch to the info scene with space pressed
		if (Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene("InfoScene");
		}
	}
}
