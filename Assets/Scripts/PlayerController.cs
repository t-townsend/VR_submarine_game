using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Transform cameraTransform;
	public float speed = 0.5f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		// get position from player object
		Vector3 target = gameObject.transform.position;

		// Move that vector3 forward at speed along cara's forward vector
		target += cameraTransform.forward * speed * Time.deltaTime;

		//Override target vector's Y position with player's current y position
		target.y = gameObject.transform.position.y;

		//Apply to game Object
		gameObject.transform.position = target;


	}
}
